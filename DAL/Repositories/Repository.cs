using DAL.Dto;
using DAL.Entities.EntityTypes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Utils;

namespace DAL.Repositories
{
    public class Repository<T, D> : IRepository<T, D>
         where T : class, IEntity
         where D : DbContext
    {
        public D DbContext { get; private set; }
        private DbSet<T> entities;
        protected readonly UserDto _user;

        public Repository(D context)
        {
            DbContext = context;
            entities = DbContext.Set<T>();

            _user = new UserDto
            {
                UserId = Guid.NewGuid()
            };
        }

        public IQueryable<T> GetAll()
        {
            return DbContext.Set<T>().AsNoTracking();
        }

        public async Task<T> GetById(Guid id)
        {
            return await DbContext.Set<T>()
                .AsNoTracking()
                .FirstOrDefaultAsync(q => q.Id.Equals(id));
        }

        public async Task<T> GetSingle(Expression<Func<T, bool>> filter = null)
        {
            return await DbContext.Set<T>()
                .Where(filter)
                .AsNoTracking()
                .FirstOrDefaultAsync();
        }

        public async Task<bool> GetAny(Expression<Func<T, bool>> filter = null)
        {
            return await DbContext.Set<T>()
                .AnyAsync(filter);
        }

        public async Task<bool> Add(T entity, bool overrideCurrentUser = false)
        {
            if (entity is IAuditedEntity)
            {
                CreateAudited(entity as IAuditedEntity, overrideCurrentUser);
            }

            if (entity.Id.Equals(Guid.Empty))
            {
                entity.SetNewId();
            }

            await DbContext.Set<T>().AddAsync(entity);
            return await Save();
        }

        public async Task<bool> Delete(T entity)
        {
            DbContext.Set<T>().Remove(entity);
            return await Save();
        }

        public async Task<bool> Update(T entity, bool overrideCurrentUser = false)
        {
            if (entity is IAuditedEntity)
            {
                UpdateAudited(entity as IAuditedEntity, overrideCurrentUser);
            }

            DbContext.Set<T>().Update(entity);
            return await Save();
        }

        public async Task<bool> Save()
        {
            bool isSaved = false;
            try
            {
                isSaved = await DbContext.SaveChangesAsync() >= 0;
            }
            catch (DbUpdateConcurrencyException ex)
            {
                var entry = ex.Entries.Single();
                entry.OriginalValues.SetValues(entry.GetDatabaseValues());
            }

            return isSaved;
        }

        public int Count()
        {
            return DbContext.Set<T>().Count();
        }

        private void CreateAudited(IAuditedEntity entity, bool overrideCurrentUser = false)
        {
            entity.DatetimeCreated = Core.SystemDateTime;
            entity.DatetimeModified = Core.SystemDateTime;
            if (_user != null && !overrideCurrentUser)
            {
                entity.CreatedBy = entity.ModifiedBy = _user.UserId;
            }
        }

        private void UpdateAudited(IAuditedEntity entity, bool overrideCurrentUser = false)
        {
            entity.DatetimeModified = Core.SystemDateTime;
            if (_user != null && !overrideCurrentUser)
            {
                entity.ModifiedBy = _user.UserId;
            }
        }
    }
}
