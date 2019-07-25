using System.Threading;
using System.Threading.Tasks;
using CRZ.Orders.Application.Basket.DTO;

namespace CRZ.Orders.Application.Basket
{
    public interface IBasketAppService
    {
        Task CreateBasket(CreateBasketDTO dto, CancellationToken cancellationToken = default);
    }
}
