using DAL.Entities.EntityTypes;
using System;

namespace DAL.Entities
{
    public partial class ClientTypes : IAuditedEntity
    {
        public Guid Id
        {
            get
            {
                return ClientTypeId;
            }
        }

        public void SetNewId()
        {
            this.ClientTypeId = Guid.NewGuid();
        }
    }
}
