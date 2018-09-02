using DAL.Entities.EntityTypes;
using System;

namespace DAL.Entities
{
    public partial class Expenses : IEntity
    {
        public Guid Id
        {
            get
            {
                return ExpenseId;
            }
        }

        public void SetNewId()
        {
            this.ExpenseId = Guid.NewGuid();
        }
    }
}
