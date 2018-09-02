using DAL.Entities.EntityTypes;
using System;

namespace DAL.Entities
{
    public partial class Payment : IAuditedEntity
    {
        public Guid Id
        {
            get
            {
                return PaymentId;
            }
        }

        public void SetNewId()
        {
            this.PaymentId = Guid.NewGuid();
        }
    }
}
