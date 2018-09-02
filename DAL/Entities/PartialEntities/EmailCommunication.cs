using DAL.Entities.EntityTypes;
using System;

namespace DAL.Entities
{
    public partial class EmailCommunication : IAuditedEntity
    {
        public Guid Id
        {
            get
            {
                return EmailCommunicationId;
            }
        }

        public void SetNewId()
        {
            this.EmailCommunicationId = Guid.NewGuid();
        }
    }
}
