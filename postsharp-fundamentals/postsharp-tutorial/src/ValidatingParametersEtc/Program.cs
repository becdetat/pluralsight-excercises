using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostSharp.Patterns.Contracts;

namespace ValidatingParametersEtc
{
    class Program
    {
        static void Main(string[] args)
        {
            NonNullRequired("pass");
            NonNullRequired(null);  // fail
            Console.WriteLine();
        }

        static void NonNullRequired([Required]string s)
        {}
    }
}
