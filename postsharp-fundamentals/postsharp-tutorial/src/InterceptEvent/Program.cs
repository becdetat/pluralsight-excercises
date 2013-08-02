using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterceptEvent
{
    public class Program
    {
        [LoggingEventInterceptionAspect]
        public event EventHandler MyEvent; 

        public void RaiseMyEvent()
        {
            if (MyEvent != null) MyEvent(this, EventArgs.Empty);
        }

        static void Main(string[] args)
        {
            var program = new Program();
            EventHandler handler = (sender, eventArgs) => Console.WriteLine("MyEvent was raised");

            program.MyEvent += handler;
            program.RaiseMyEvent();
            program.MyEvent -= handler;

            program.MyEvent += (sender, eventArgs) => { throw new Exception("oh noes"); };
            program.RaiseMyEvent();

            Console.ReadKey();
        }
    }
}
