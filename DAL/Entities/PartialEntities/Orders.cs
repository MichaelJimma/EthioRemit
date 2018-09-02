using DAL.Entities.EntityTypes;
using System;

namespace DAL.Entities
{
    public partial class Orders : IAuditedEntity
    {
        public Guid Id
        {
            get
            {
                return OrderId;
            }
        }

        public void SetNewId()
        {
            this.OrderId = Guid.NewGuid();
        }
    }
}
