using DAL.Entities.EntityTypes;
using System;

namespace DAL.Entities
{
    public partial class CashOnHand : IEntity
    {
        public Guid Id
        {
            get
            {
                return CashOnHandId;
            }
        }

        public void SetNewId()
        {
            this.CashOnHandId = Guid.NewGuid();
        }
    }
}
