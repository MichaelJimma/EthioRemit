using DAL.Entities.EntityTypes;
using System;

namespace DAL.Entities
{
    public partial class PaymentStatus : IAuditedEntity
    {
        public Guid Id
        {
            get
            {
                return PaymentStatusId;
            }
        }

        public void SetNewId()
        {
            this.PaymentStatusId = Guid.NewGuid();
        }
    }
}
