using System;
using CRZ.Framework.Domain;

namespace CRZ.Orders.Domain.OrdersAggregate
{
    public class Order : BaseEntity, IAggregation
    {
        public Basket Basket { get; private set; }

        public Address Address { get; private set; }

        public OrderStatus OrderStatus { get; private set; }

        public Order(Basket basket, Address address)
            : this(basket, address, OrderStatus.Placed)
        { }

        public Order(Basket basket, Address address, OrderStatus orderStatus)
        {
            Basket = basket ?? throw new ArgumentNullException(nameof(basket));
            Address = address ?? throw new ArgumentNullException(nameof(address));
            OrderStatus = orderStatus;
            CreatedAt = DateTimeOffset.Now;
        }

        public void ChangeStatus(OrderStatus newStatus)
        {
            OrderStatus = newStatus;
        }
    }
}
