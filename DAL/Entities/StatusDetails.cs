using System;

namespace DAL.Entities
{
    public partial class StatusDetails
    {
        public Guid StatusDetailId { get; set; }
        public Guid StatusId { get; set; }
        public string Detail { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime DatetimeCreated { get; set; }
        public Guid ModifiedBy { get; set; }
        public DateTime DatetimeModified { get; set; }
        public bool IsDeleted { get; set; }

        public Status Status { get; set; }
    }
}
