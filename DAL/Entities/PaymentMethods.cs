using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public partial class PaymentMethods
    {
        public PaymentMethods()
        {
            Payment = new HashSet<Payment>();
        }

        public Guid PaymentMethodId { get; set; }
        public string Name { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime DatetimeCreated { get; set; }
        public Guid ModifiedBy { get; set; }
        public DateTime DatetimeModified { get; set; }
        public bool IsDeleted { get; set; }

        public ICollection<Payment> Payment { get; set; }
    }
}
