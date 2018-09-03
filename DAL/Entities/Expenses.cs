using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public partial class Expenses
    {
        public Guid ExpenseId { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
    }
}
