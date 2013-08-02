using System.Collections.Generic;
using System.Linq;
using PostSharp.Patterns.Threading;

namespace ThreadUnsafe
{
    // honestly not very interesting
    //[ThreadUnsafe]
    public class CrazyQueue// : Actor
    {
        private readonly Queue<int> _queue;

        public CrazyQueue()
        {
            _queue = new Queue<int>();
        }

        public void Enqueue(int i)
        {
            _queue.Enqueue(i);
        }

        public int? Dequeue()
        {
            return _queue.Any() ? _queue.Dequeue() : default(int?);
        }
    }
}