/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

namespace Easy.RuleEngine.RuleProviders
{
    public class MoneyRuleProvider : IRuleProvider
    {
        const string FunctionName = "Money";
        public void Process(RuleContext ruleContext, object workContext)
        {
            if (ruleContext.FunctionName == FunctionName)
            {
                decimal value;
                if (decimal.TryParse(ruleContext.Arguments[0].ToString(), out value))
                {
                    ruleContext.Result = value;
                }
            }
        }
    }
}
