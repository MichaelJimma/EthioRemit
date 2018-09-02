using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public partial class Clients
    {
        public Clients()
        {
            Accounts = new HashSet<Accounts>();
            ClientReceiveds = new HashSet<ClientReceiveds>();
            Orders = new HashSet<Orders>();
            Payment = new HashSet<Payment>();
        }

        public Guid ClientId { get; set; }
        public string AgentCode { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public Guid ClientTypeId { get; set; }
        public bool? IsActive { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime DatetimeCreated { get; set; }
        public Guid ModifiedBy { get; set; }
        public DateTime DatetimeModified { get; set; }
        public bool IsDeleted { get; set; }

        public ClientTypes ClientType { get; set; }
        public ICollection<Accounts> Accounts { get; set; }
        public ICollection<ClientReceiveds> ClientReceiveds { get; set; }
        public ICollection<Orders> Orders { get; set; }
        public ICollection<Payment> Payment { get; set; }
    }
}
