using DAL.Entities;
using DAL.Entities.EntityTypes;

namespace DAL.Repositories
{
    public interface IEthioRemitEntitiesRepository<T> : IRepository<T, EthioRemitContext>
        where T : class, IEntity
    { }
}
