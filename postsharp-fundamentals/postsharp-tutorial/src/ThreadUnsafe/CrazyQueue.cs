using System.Collections.Generic;
using System.Linq;

namespace ThreadUnsafe
{
    public class CrazyQueue
    {
        private readonly Queue<int> _queue = new Queue<int>();

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