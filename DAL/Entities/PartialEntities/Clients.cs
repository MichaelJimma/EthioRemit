using DAL.Entities.EntityTypes;
using System;

namespace DAL.Entities
{
    public partial class Clients : IAuditedEntity
    {
        public Guid Id
        {
            get
            {
                return ClientId;
            }
        }

        public void SetNewId()
        {
            this.ClientId = Guid.NewGuid();
        }
    }
}
