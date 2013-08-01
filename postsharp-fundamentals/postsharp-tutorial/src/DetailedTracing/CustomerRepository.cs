using System.Collections.Generic;
using System.Linq;

namespace DetailedTracing
{
    public class CustomerRepository
    {
        private static IList<Customer> _db = new List<Customer>();

        public void SaveCustomer(string firstName, string lastName, string street, string city)
        {
            _db.Add(new Customer(firstName, lastName, street, city));
        }

        public Customer[] GetAll()
        {
            return _db.ToArray();
        }
    }
}