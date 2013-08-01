using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetailedTracing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Saving customers");
            SaveCustomer("Donald", "Belcham", "Queen Street", "Brisbane");
            SaveCustomer("Yan", "Cui", "Gladstone Road", "Rockhampton");

            Console.WriteLine("Reading customers:");
            foreach (var customer in new CustomerRepository().GetAll())
            {
                Console.WriteLine(customer.ToString());
            }

            Console.ReadKey();
        }

        static void SaveCustomer(string firstName, string lastName, string street, string city)
        {
            var customerRepository = new CustomerRepository();
            customerRepository.SaveCustomer(firstName, lastName, street, city);
        }
    }
}
