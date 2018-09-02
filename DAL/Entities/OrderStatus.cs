using System;

namespace DAL.Entities
{
    public partial class OrderStatus
    {
        public Guid OrderStatusId { get; set; }
        public Guid OrderId { get; set; }
        public Guid StatusId { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime DatetimeCreated { get; set; }
        public Guid ModifiedBy { get; set; }
        public DateTime DatetimeModified { get; set; }
        public bool IsDeleted { get; set; }

        public Orders Order { get; set; }
        public Status Status { get; set; }
    }
}
