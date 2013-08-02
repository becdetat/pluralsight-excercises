using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostSharp.Aspects;

namespace Multicasting
{
    // Nice in theory but it doesn't get loaded up??

    public class MyAspectProvider : IAspectProvider
    {
        public IEnumerable<AspectInstance> ProvideAspects(object targetElement)
        {
            return from method in ((Type) targetElement).GetMethods()
                   select new AspectInstance(targetElement, new LoggingAspect("Category"));
        }
    }
}
