using System;

namespace CRZ.Orders.Domain.OrdersAggregate
{
    public class Address : BaseValueObject
    {
        public string Street { get; private set; }

        public string Number { get; private set; }

        public string ZipCode { get; private set; }

        public string Complement { get; private set; }

        public string City { get; private set; }

        public string State { get; private set; }

        public Address(string street,
                       string number,
                       string zipcode,
                       string complement,
                       string city,
                       string state)
        {
            Street = street ?? throw new ArgumentNullException(nameof(street));
            Number = number ?? throw new ArgumentNullException(nameof(number));
            ZipCode = zipcode ?? throw new ArgumentNullException(nameof(zipcode));
            Complement = complement ?? throw new ArgumentNullException(nameof(complement));
            City = city ?? throw new ArgumentNullException(nameof(city));
            State = state ?? throw new ArgumentNullException(nameof(state));
            CreatedAt = DateTimeOffset.Now;
        }
    }
}
