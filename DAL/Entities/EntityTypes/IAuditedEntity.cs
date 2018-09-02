using System;

namespace DAL.Entities.EntityTypes
{
    public interface IAuditedEntity : IEntity
    {
        Guid CreatedBy { get; set; }
        DateTime DatetimeCreated { get; set; }
        Guid ModifiedBy { get; set; }
        DateTime DatetimeModified { get; set; }
    }
}
