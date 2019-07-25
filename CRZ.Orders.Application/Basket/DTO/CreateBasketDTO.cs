using System.Collections.Generic;

namespace CRZ.Orders.Application.Basket.DTO
{
    public class CreateBasketDTO
    {
        public string ContractNumber { get; set; }

        public string CardNumber { get; set; }

        public IEnumerable<ProductDTO> Products { get; set; }
    }
}
