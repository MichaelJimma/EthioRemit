using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public partial class Payment
    {
        public Guid PaymentId { get; set; }
        public Guid AccountId { get; set; }
        public Guid ClientId { get; set; }
        public Guid PaymentMethodId { get; set; }
        public Guid PaymentStatusId { get; set; }
        public decimal PaymentAmount { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime DatetimeCreated { get; set; }
        public Guid ModifiedBy { get; set; }
        public DateTime DatetimeModified { get; set; }
        public bool IsDeleted { get; set; }

        public Accounts Account { get; set; }
        public Clients Client { get; set; }
        public PaymentMethods PaymentMethod { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
    }
}
