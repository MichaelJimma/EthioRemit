using DAL.Entities.EntityTypes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class Repository<T, D> : IRepository<T, D>
         where T : class, IEntity
         where D : DbContext
    {
        public D DbContext { get; private set; }
        private DbSet<T> entities;

        public Repository(D context)
        {
            DbContext = context;
            entities = DbContext.Set<T>();
        }

        public IQueryable<T> GetAll()
        {
            return DbContext.Set<T>().AsNoTracking();
        }

        public async Task<T> GetSingle(Guid id)
        {
            return await DbContext.Set<T>()
                .AsNoTracking()
                .FirstOrDefaultAsync(q => q.Id.Equals(id));
        }

        public async Task<bool> Add(T entity)
        {
            await DbContext.Set<T>().AddAsync(entity);
            return await Save();
        }

        public async Task<bool> Delete(T entity)
        {
            DbContext.Set<T>().Remove(entity);
            return await Save();
        }

        public async Task<bool> Update(T entity)
        {
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
    }
}
