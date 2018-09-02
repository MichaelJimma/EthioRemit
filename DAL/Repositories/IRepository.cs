using DAL.Entities.EntityTypes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public interface IRepository<T, D>
       where T : class, IEntity
       where D : DbContext
    {
        IQueryable<T> GetAll();
        Task<T> GetSingle(Guid id);
        Task<bool> Add(T entity);
        Task<bool> Delete(T entity);
        Task<bool> Update(T entity);
        Task<bool> Save();
        int Count();
    }
}
