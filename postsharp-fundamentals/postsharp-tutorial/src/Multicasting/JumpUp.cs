using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multicasting
{
    public class JumpUp : IDoSomething
    {
        public void DoSomething()
        {
            Console.WriteLine("Jump up");
        }
    }
}
