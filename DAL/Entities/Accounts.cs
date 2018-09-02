using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public partial class Accounts
    {
        public Accounts()
        {
            Payment = new HashSet<Payment>();
        }

        public Guid AccountId { get; set; }
        public Guid ClientId { get; set; }
        public string AccountName { get; set; }
        public decimal? CurrentBalance { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime DatetimeCreated { get; set; }
        public Guid ModifiedBy { get; set; }
        public DateTime DatetimeModified { get; set; }
        public bool IsDeleted { get; set; }

        public Clients Client { get; set; }
        public ICollection<Payment> Payment { get; set; }
    }
}
