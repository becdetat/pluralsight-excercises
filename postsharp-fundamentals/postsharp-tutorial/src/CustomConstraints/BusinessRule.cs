using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomConstraints
{
    [BusinessRulePatternValidation]
    public class PassingBusinessRule
    {
        public class Factory
        {
        }
    }

    [BusinessRulePatternValidation]
    public class FailingBusinessRule
    {
    }

    public class UncheckedBusinessRule
    {
    }
}
