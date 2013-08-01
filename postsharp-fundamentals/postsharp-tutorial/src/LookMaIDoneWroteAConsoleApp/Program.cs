using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LookMaIDoneWroteAConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));

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
}
