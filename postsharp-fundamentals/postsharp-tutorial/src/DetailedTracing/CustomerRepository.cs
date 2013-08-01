using System.Collections.Generic;
using System.Linq;
using PostSharp.Patterns.Diagnostics;
using PostSharp.Extensibility;

namespace DetailedTracing
{
    public class CustomerRepository
    {
        private static IList<Customer> _db = new List<Customer>();

        [Log]
        public void SaveCustomer(string firstName, string lastName, string street, string city)
        {
            _db.Add(new Customer(firstName, lastName, street, city));
        }

        [Log]
        public Customer[] GetAll()
        {
            return _db.ToArray();
        }
    }
}