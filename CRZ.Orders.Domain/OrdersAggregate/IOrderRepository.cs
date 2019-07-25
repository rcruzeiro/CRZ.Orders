using CRZ.Framework.Domain;

namespace CRZ.Orders.Domain.OrdersAggregate
{
    public interface IOrderRepository : IRepositoryAsync<Order>
    { }
}
