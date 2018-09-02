using DAL.Entities.EntityTypes;
using System;

namespace DAL.Entities
{
    public partial class ClientReceiveds : IAuditedEntity
    {
        public Guid Id
        {
            get
            {
                return ClientReceivedId;
            }
        }

        public void SetNewId()
        {
            this.ClientReceivedId = Guid.NewGuid();
        }
    }
}
