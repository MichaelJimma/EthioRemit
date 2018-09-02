using DAL.Entities.EntityTypes;
using System;

namespace DAL.Entities
{
    public partial class StatusDetails : IAuditedEntity
    {
        public Guid Id
        {
            get
            {
                return StatusDetailId;
            }
        }

        public void SetNewId()
        {
            this.StatusDetailId = Guid.NewGuid();
        }
    }
}
