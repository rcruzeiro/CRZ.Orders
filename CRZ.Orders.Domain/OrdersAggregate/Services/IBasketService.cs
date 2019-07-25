using System.Threading;
using System.Threading.Tasks;
using CRZ.Orders.Domain.OrdersAggregate.Commands;

namespace CRZ.Orders.Domain.OrdersAggregate
{
    public interface IBasketService
    {
        Task<Basket> CreateBasket(CreateBasketCommand command, CancellationToken cancellationToken = default);
    }
}
