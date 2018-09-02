using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public partial class Orders
    {
        public Orders()
        {
            OrderReceipt = new HashSet<OrderReceipt>();
            OrderStatus = new HashSet<OrderStatus>();
        }

        public Guid OrderId { get; set; }
        public Guid ClientId { get; set; }
        public string SenderName { get; set; }
        public string SenderPhone { get; set; }
        public string SenderEmail { get; set; }
        public string ReceiverName { get; set; }
        public string ReceiverPhone { get; set; }
        public string City { get; set; }
        public string AccountNumber { get; set; }
        public string Bank { get; set; }
        public decimal AmountCad { get; set; }
        public decimal AmountBirr { get; set; }
        public decimal ExchangeRate { get; set; }
        public string OrderDescription { get; set; }
        public bool? HoldTransfer { get; set; }
        public bool? Transferred { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime DatetimeCreated { get; set; }
        public Guid ModifiedBy { get; set; }
        public DateTime DatetimeModified { get; set; }
        public bool IsDeleted { get; set; }

        public Clients Client { get; set; }
        public ICollection<OrderReceipt> OrderReceipt { get; set; }
        public ICollection<OrderStatus> OrderStatus { get; set; }
    }
}
