using DAL.Entities.EntityTypes;
using System;

namespace DAL.Entities
{
    public partial class OrderStatus : IAuditedEntity
    {
        public Guid Id
        {
            get
            {
                return OrderStatusId;
            }
        }

        public void SetNewId()
        {
            this.OrderStatusId = Guid.NewGuid();
        }
    }
}
