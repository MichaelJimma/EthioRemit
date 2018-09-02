using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public partial class ClientTypes
    {
        public ClientTypes()
        {
            Clients = new HashSet<Clients>();
        }

        public Guid ClientTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime DatetimeCreated { get; set; }
        public Guid ModifiedBy { get; set; }
        public DateTime DatetimeModified { get; set; }
        public bool IsDeleted { get; set; }

        public ICollection<Clients> Clients { get; set; }
    }
}
