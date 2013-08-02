using System;

namespace Multicasting
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var somethings = new IDoSomething[]
                {
                    new JumpAround(), 
                    new JumpAround(), 
                    new JumpAround(), 
                    new JumpAround(),
                    new JumpUp(), 
                    new JumpUp(),
                    new JumpDown(),
                    new Jump(),
                    new Jump(),
                    new Jump(),
                    new Jump(),
                    new Jump(),
                    new Jump(),
                    new Jump(),
                    new Jump(),
                    new Jump(),
                    new Jump(),
                    new Jump(),
                    new Jump(),
                    new Jump(),
                    new Jump(),
                    new Jump(),
                    new Jump(),
                    new Jump(),
                };

            foreach (IDoSomething s in somethings) s.DoSomething();
            Console.ReadKey();
        }
    }
}