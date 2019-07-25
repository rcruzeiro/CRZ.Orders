using System;
using System.Collections.Generic;
using System.Linq;
using CRZ.Framework.Domain;

namespace CRZ.Orders.Domain.OrdersAggregate.Commands
{
    public class CreateBasketCommand : ICommand
    {
        public User User { get; }

        public IEnumerable<Product> Products { get; }

        public CreateBasketCommand(User user, IEnumerable<Product> products)
        {
            User = user;
            Products = products;
        }

        public void Validate()
        {
            if (User == null) throw new ArgumentNullException(nameof(User));

            if (Products == null || !Products.Any()) throw new ArgumentNullException(nameof(Products));
        }
    }
}
