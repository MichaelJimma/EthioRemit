using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public partial class ClientReceiveds
    {
        public Guid ClientReceivedId { get; set; }
        public Guid ClientId { get; set; }
        public decimal ReceivedBirr { get; set; }
        public decimal Rate { get; set; }
        public decimal ExchangeAmount { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime DatetimeCreated { get; set; }
        public Guid ModifiedBy { get; set; }
        public DateTime DatetimeModified { get; set; }
        public bool IsDeleted { get; set; }

        public Clients Client { get; set; }
    }
}
