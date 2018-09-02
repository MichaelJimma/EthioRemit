using DAL.Entities;
using DAL.Entities.EntityTypes;

namespace DAL.Repositories
{
    public class EthioRemitEntitiesRepository<T> : Repository<T, EthioRemitContext>, IEthioRemitEntitiesRepository<T>
        where T : class, IEntity
    {
        public EthioRemitEntitiesRepository(EthioRemitContext context)
            : base(context) { }
    }
}
