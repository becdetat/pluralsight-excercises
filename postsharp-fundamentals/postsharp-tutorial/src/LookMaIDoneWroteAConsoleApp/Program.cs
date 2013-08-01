using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LookMaIDoneWroteAConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHello();
            SayGoodbye();

            Console.ReadKey();
        }

        [Trace("Category A")]
        private static void SayGoodbye()
        {
            Console.WriteLine("Goodbye");
        }

        [Trace("Category A")]
        private static void SayHello()
        {
            Console.WriteLine("Hello");
        }
    }

    internal class TraceAttribute : Attribute
    {
        public string Category { get; private set; }

        public TraceAttribute(string category)
        {
            Category = category;
        }
    }
}
