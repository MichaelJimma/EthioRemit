using System;

namespace DAL.Entities
{
    public partial class OrderReceipt
    {
        public Guid OrderReceiptId { get; set; }
        public Guid OrderId { get; set; }
        public string Name { get; set; }
        public string FileName { get; set; }
        public string FileExtension { get; set; }
        public int? Size { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime DatetimeCreated { get; set; }
        public Guid ModifiedBy { get; set; }
        public DateTime DatetimeModified { get; set; }
        public bool IsDeleted { get; set; }

        public Orders Order { get; set; }
    }
}
