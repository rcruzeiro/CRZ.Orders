using System;
using CRZ.Framework.Domain;

namespace CRZ.Orders.Domain
{
    public abstract class BaseValueObject : IValueObject
    {
        public int Id { get; protected set; }

        public DateTimeOffset CreatedAt { get; protected set; }

        protected BaseValueObject()
        { }
    }
}
