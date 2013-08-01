using bi.Shared;

namespace DetailedTracing
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }

        public Customer(string firstName, string lastName, string street, string city)
        {
            FirstName = firstName;
            LastName = lastName;
            Street = street;
            City = city;
        }

        public override string ToString()
        {
            return "{0} {1}, {2}, {3}".FormatWith(FirstName, LastName, Street, City);
        }
    }
}