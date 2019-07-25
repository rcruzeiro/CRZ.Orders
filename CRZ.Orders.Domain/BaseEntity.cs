using System;
using CRZ.Framework.Domain;

namespace CRZ.Orders.Domain
{
    public abstract class BaseEntity : IEntity
    {
        public int Id { get; protected set; }

        public DateTimeOffset CreatedAt { get; protected set; }

        public DateTimeOffset? UpdatedAt { get; protected set; }

        protected BaseEntity()
        { }
    }
}
