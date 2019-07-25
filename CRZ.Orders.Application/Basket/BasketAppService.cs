using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CRZ.Framework.Cache;
using CRZ.Orders.Application.Basket.DTO;
using CRZ.Orders.Domain.OrdersAggregate;
using CRZ.Orders.Domain.OrdersAggregate.Commands;

namespace CRZ.Orders.Application.Basket
{
    public class BasketAppService : IBasketAppService
    {
        readonly ICacheService _cacheService;
        readonly IBasketService _basketService;

        public BasketAppService(ICacheService cacheService, IBasketService basketService)
        {
            _cacheService = cacheService ?? throw new ArgumentNullException(nameof(cacheService));
            _basketService = basketService ?? throw new ArgumentNullException(nameof(basketService));
        }

        public async Task CreateBasket(CreateBasketDTO dto, CancellationToken cancellationToken = default)
        {
            var user = new User(dto.ContractNumber, dto.CardNumber);
            var products = new List<Product>();

            // assemble DTO in Domain
            dto.Products
               .ToList()
               .ForEach(product => products.Add(product.Assemble()));

            // create new basket with CreateBasketCommand
            var createCommand = new CreateBasketCommand(user, products);
            var basket = await _basketService.CreateBasket(createCommand, cancellationToken);

            // save the basket into the cache
            _cacheService.SetValue($"basket_{user.ContractNumber}_{user.CardNumber}",
                                   basket,
                                   TimeSpan.FromDays(1));
        }
    }
}
