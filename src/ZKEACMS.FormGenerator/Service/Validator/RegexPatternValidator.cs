/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy.Extend;
using System.Text.RegularExpressions;
using ZKEACMS.FormGenerator.Models;

namespace ZKEACMS.FormGenerator.Service.Validator
{
    public class RegexPatternValidator : IFormDataValidator
    {
        public bool Validate(FormField field, FormDataItem data, out string message)
        {
            message = string.Empty;
            if (field.RegexPattern.IsNotNullAndWhiteSpace() && data.FieldValue.IsNotNullAndWhiteSpace() && !Regex.IsMatch(data.FieldValue, field.RegexPattern))
            {
                message = field.RegexMessage;
                return false;
            }
            return true;
        }
    }
}
