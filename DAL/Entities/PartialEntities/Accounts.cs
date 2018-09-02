using DAL.Entities.EntityTypes;
using System;

namespace DAL.Entities
{
    public partial class Accounts : IAuditedEntity
    {
        public Guid Id
        {
            get
            {
                return AccountId;
            }
        }

        public void SetNewId()
        {
            this.AccountId = Guid.NewGuid();
        }
    }
}
