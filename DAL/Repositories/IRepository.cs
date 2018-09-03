using DAL.Entities.EntityTypes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public interface IRepository<T, D>
       where T : class, IEntity
       where D : DbContext
    {
        IQueryable<T> GetAll();
        Task<T> GetById(Guid id);
        Task<T> GetSingle(Expression<Func<T, bool>> filter = null);
        Task<bool> GetAny(Expression<Func<T, bool>> filter = null);
        Task<bool> Add(T entity, bool overrideCurrentUser = false);
        Task<bool> Delete(T entity);
        Task<bool> Update(T entity, bool overrideCurrentUser = false);
        Task<bool> Save();
        int Count();
    }
}
