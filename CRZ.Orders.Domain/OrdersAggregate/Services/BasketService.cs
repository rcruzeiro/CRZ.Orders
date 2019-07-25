using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CRZ.Orders.Domain.OrdersAggregate.Commands;

namespace CRZ.Orders.Domain.OrdersAggregate
{
    public class BasketService : IBasketService
    {
        readonly IProductProviderService _productProviderService;

        public BasketService(IProductProviderService productProviderService)
        {
            _productProviderService = productProviderService ?? throw new ArgumentNullException(nameof(productProviderService));
        }

        public async Task<Basket> CreateBasket(CreateBasketCommand command, CancellationToken cancellationToken = default)
        {
            command.Validate();

            var productsInStock = new List<Product>();

            async void action(Product product)
            {
                var inStock = await _productProviderService.ValidateProductStock(product.EAN);

                if (inStock) productsInStock.Add(product);
            }

            command.Products
                   .ToList()
                   .ForEach(action);

            if (!productsInStock.Any()) throw new InvalidOperationException("none of the products have stock.");

            var basket = await Task.FromResult(new Basket(command.User, productsInStock));

            return basket;
        }
    }
}
