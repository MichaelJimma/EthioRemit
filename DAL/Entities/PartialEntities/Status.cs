using DAL.Entities.EntityTypes;
using System;

namespace DAL.Entities
{
    public partial class Status : IAuditedEntity
    {
        public Guid Id
        {
            get
            {
                return StatusId;
            }
        }

        public void SetNewId()
        {
            this.StatusId = Guid.NewGuid();
        }
    }
}
