using System;

namespace DAL.Entities
{
    public partial class CashOnHand
    {
        public Guid CashOnHandId { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
    }
}
