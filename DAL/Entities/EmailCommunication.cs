using System;

namespace DAL.Entities
{
    public partial class EmailCommunication
    {
        public Guid EmailCommunicationId { get; set; }
        public string Email { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime DatetimeCreated { get; set; }
        public Guid ModifiedBy { get; set; }
        public DateTime DatetimeModified { get; set; }
        public bool IsDeleted { get; set; }
    }
}
