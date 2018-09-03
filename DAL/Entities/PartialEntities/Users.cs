using DAL.Entities.EntityTypes;
using System;

namespace DAL.Entities
{
    public partial class Users : IAuditedEntity
    {
        public Guid Id
        {
            get
            {
                return UserId;
            }
        }

        public void SetNewId()
        {
            this.UserId = Guid.NewGuid();
        }
    }
}
