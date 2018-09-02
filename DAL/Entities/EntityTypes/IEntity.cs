using System;

namespace DAL.Entities.EntityTypes
{
    public interface IEntity
    {
        Guid Id { get; }
        void SetNewId();
    }
}
