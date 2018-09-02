using DAL.Entities.EntityTypes;
using System;

namespace DAL.Entities
{
    public partial class PaymentMethods : IAuditedEntity
    {
        public Guid Id
        {
            get
            {
                return PaymentMethodId;
            }
        }

        public void SetNewId()
        {
            this.PaymentMethodId = Guid.NewGuid();
        }
    }
}
