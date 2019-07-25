using System;

namespace CRZ.Orders.Domain.OrdersAggregate
{
    public class Product : BaseValueObject
    {
        public string EAN { get; private set; }

        public string Name { get; private set; }

        public string Presentation { get; private set; }

        public decimal Price { get; private set; }

        public Product(string ean, string name, string presentation, decimal price)
        {
            EAN = ean ?? throw new ArgumentNullException(nameof(ean));
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Presentation = presentation ?? throw new ArgumentNullException(nameof(presentation));
            Price = price;
            CreatedAt = DateTimeOffset.Now;
        }
    }
}
