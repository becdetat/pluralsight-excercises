using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostSharp.Aspects;
using bi.Shared;

namespace Multicasting
{
    [Serializable]
    public class LoggingAspect : OnMethodBoundaryAspect
    {
        public string Category { get; private set; }

        public LoggingAspect(string category)
        {
            Category = category;
        }

        public override void OnEntry(MethodExecutionArgs args)
        {
            Trace.WriteLine("Entering {0}.{1}".FormatWith(args.Method.DeclaringType.Name, args.Method.Name), Category);
        }

        public override void OnExit(MethodExecutionArgs args)
        {
            Trace.WriteLine("Exiting {0}.{1}".FormatWith(args.Method.DeclaringType.Name, args.Method.Name), Category);
        }
    }
}
