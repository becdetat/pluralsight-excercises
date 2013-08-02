using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostSharp.Constraints;
using PostSharp.Extensibility;

namespace CustomConstraints
{
    [MulticastAttributeUsage(MulticastTargets.Class, Inheritance = MulticastInheritance.Strict)]
    public class BusinessRulePatternValidation : ScalarConstraint
    {
        public override void ValidateCode(object target)
        {
            var targetType = (Type) target;
            if (targetType.GetNestedType("Factory") == null)
            {
                Message.Write(
                    targetType, SeverityType.Warning,
                    "2001", "The {0} type does not have a nested type named 'Factory'", targetType.Name);
            }
        }

        public override bool ValidateConstraint(object target)
        {
            var targetType = (Type)target;

            if (targetType.Namespace == "IgnoredNamespace") return false;

            return true;
        }
    }
}
