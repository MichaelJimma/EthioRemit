using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public partial class PaymentStatus
    {
        public PaymentStatus()
        {
            Payment = new HashSet<Payment>();
        }

        public Guid PaymentStatusId { get; set; }
        public string PaymentStatusName { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime DatetimeCreated { get; set; }
        public Guid ModifiedBy { get; set; }
        public DateTime DatetimeModified { get; set; }
        public bool IsDeleted { get; set; }

        public ICollection<Payment> Payment { get; set; }
    }
}
