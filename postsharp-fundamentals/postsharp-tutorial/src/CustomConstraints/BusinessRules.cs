using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controllers;
using CustomConstraints;
using PostSharp;

namespace Controllers
{
    public abstract class BusinessRule
    {
    }

    [BusinessRulePatternValidation]
    public class PassingBusinessRule : BusinessRule
    {
        public class Factory
        {
        }
    }

    [BusinessRulePatternValidation]
    public class FailingBusinessRule : BusinessRule
    {
    }

    public class UncheckedBusinessRule : BusinessRule
    {
    }

    [BusinessRulePatternValidation]
    [IgnoreWarning("2001")]
    public class FailingBusinessRuleWithWarningIgnored : BusinessRule
    {
    }
}

namespace NotControllers
{
    [BusinessRulePatternValidation]
    public class FailingBusinessRuleInWrongNamespace : BusinessRule
    {
    }

    public class UncheckedBusinessRule : BusinessRule
    {
    }
}

namespace IgnoredNamespace
{
    [BusinessRulePatternValidation]
    public class FailingBusinessRuleShouldBeIgnored : BusinessRule
    {
    }
}