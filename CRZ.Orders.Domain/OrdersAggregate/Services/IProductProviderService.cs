using System.Threading;
using System.Threading.Tasks;

namespace CRZ.Orders.Domain.OrdersAggregate
{
    public interface IProductProviderService
    {
        Task<bool> ValidateProductStock(string ean, CancellationToken cancellationToken = default);
    }
}
