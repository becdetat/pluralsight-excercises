using System;
using System.Linq;

namespace ThreadUnsafe
{
    internal class Program
    {
        private static void Main()
        {
            var queue = new CrazyQueue();

            var threads = Environment.ProcessorCount;

            Console.WriteLine("Inconsistencies from queue being shared over {0} threads:", threads);

            Enumerable.Range(0, threads).AsParallel().ForAll(x =>
                {
                    var rand = new Random();
                    for (;;)
                    {
                        try
                        {
                            int a = rand.Next();
                            queue.Enqueue(a);
                            int? b = queue.Dequeue();
                            if (a != b)
                                Console.WriteLine("{0}: in {1} out {2}", x, a, b.HasValue ? b.ToString() : "null");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                });
        }
    }
}