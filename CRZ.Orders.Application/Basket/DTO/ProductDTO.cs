using System;
using CRZ.Orders.Domain.OrdersAggregate;

namespace CRZ.Orders.Application.Basket.DTO
{
    public class ProductDTO
    {
        public string EAN { get; set; }

        public string Name { get; set; }

        public string Presentation { get; set; }

        public decimal Price { get; set; }
    }

    public static class ProductDTOExtensions
    {
        public static Product Assemble(this ProductDTO dto)
        {
            if (dto == null) throw new ArgumentNullException(nameof(dto));

            var domain = new Product(dto.EAN, dto.Name, dto.Presentation, dto.Price);

            return domain;
        }
    }
}
