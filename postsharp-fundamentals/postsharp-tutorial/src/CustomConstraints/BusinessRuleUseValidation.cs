using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controllers;
using PostSharp.Constraints;
using PostSharp.Extensibility;
using PostSharp.Reflection;

namespace CustomConstraints
{
    [MulticastAttributeUsage(MulticastTargets.Class, Inheritance = MulticastInheritance.Strict)]
    public class BusinessRuleUseValidation : ReferentialConstraint
    {
        public override void ValidateCode(object target, System.Reflection.Assembly assembly)
        {
            var targetType = (Type) target;
            var usages = ReflectionSearch.GetMethodsUsingDeclaration(typeof (BusinessRule));
            if (usages != null)
            {
                Message.Write(
                    targetType, SeverityType.Warning,
                    "2002", 
                    "The {0} type contains a reference to 'BusinessRule' which should only be referenced in the Controllers namespace",
                    targetType.Name);
            }
        }
    }
}
