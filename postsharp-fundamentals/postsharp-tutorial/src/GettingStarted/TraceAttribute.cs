using System;
using System.Diagnostics;
using PostSharp.Aspects;
using bi.Shared;

namespace LookMaIDoneWroteAConsoleApp
{
    [Serializable]
    public class TraceAttribute : OnMethodBoundaryAspect
    {
        public string Category { get; private set; }

        public TraceAttribute(string category)
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