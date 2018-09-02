using DAL.Entities.EntityTypes;
using System;

namespace DAL.Entities
{
    public partial class OrderReceipt : IAuditedEntity
    {
        public Guid Id
        {
            get
            {
                return OrderReceiptId;
            }
        }

        public void SetNewId()
        {
            this.OrderReceiptId = Guid.NewGuid();
        }
    }
}
