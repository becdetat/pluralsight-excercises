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

        private static void SayGoodbye()
        {
            Console.WriteLine("Goodbye");
        }

        private static void SayHello()
        {
            Console.WriteLine("Hello");
        }
    }
}
