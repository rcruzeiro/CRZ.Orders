using System;

namespace CRZ.Orders.Domain.OrdersAggregate
{
    public class User : BaseValueObject
    {
        public string ContractNumber { get; private set; }

        public string CardNumber { get; private set; }

        public User(string contractNumber, string cardNumber)
        {
            ContractNumber = contractNumber ?? throw new ArgumentNullException(nameof(contractNumber));
            CardNumber = cardNumber ?? throw new ArgumentNullException(nameof(cardNumber));
            CreatedAt = DateTimeOffset.Now;
        }
    }
}
