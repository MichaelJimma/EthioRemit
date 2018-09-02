using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public partial class Status
    {
        public Status()
        {
            OrderStatus = new HashSet<OrderStatus>();
            StatusDetails = new HashSet<StatusDetails>();
        }

        public Guid StatusId { get; set; }
        public string Name { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime DatetimeCreated { get; set; }
        public Guid ModifiedBy { get; set; }
        public DateTime DatetimeModified { get; set; }
        public bool IsDeleted { get; set; }

        public ICollection<OrderStatus> OrderStatus { get; set; }
        public ICollection<StatusDetails> StatusDetails { get; set; }
    }
}
