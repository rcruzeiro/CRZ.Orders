using System;
using System.Collections.Generic;

namespace CRZ.Orders.Domain.OrdersAggregate
{
    public class Basket : BaseEntity
    {
        readonly List<Product> _products = new List<Product>();

        public User User { get; private set; }

        public IReadOnlyCollection<Product> Products => _products;

        internal Basket(User user, IEnumerable<Product> products)
        {
            User = user ?? throw new ArgumentNullException(nameof(user));
            CreatedAt = DateTimeOffset.Now;
            _products.AddRange(products);
        }

        internal void AddProduct(Product product)
        {
            _products.Add(product);
        }
    }
}
