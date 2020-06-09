using Flunt.Validations;
using PaymentContext.Shared.ValueObjects;

namespace PayementContext.Domain.ValueObjects
{
    public class Adress : ValueObject
    {
        public Adress(string street, string number, string neighborhood, string city, string state, string country, string zipCode)
        {
            Street = street;
            Number = number;
            Neighborhood = neighborhood;
            City = city;
            State = state;
            Country = country;
            ZipCode = zipCode;
            AddNotifications(new Contract()
            .Requires()
            .HasMinLen(Street, 3, "Adress.Street", "A rua deve possuir pelo menos 3 caracteres"));
        }

        public string Street { get; private set; }
        public string Number { get; private set; }
        public string Neighborhood { get; private set; }
        public string City { get; set; }
        public string State { get; private set; }
        public string Country { get; private set; }
        public string ZipCode { get; private set; }
    }
}