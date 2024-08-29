/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy;
using Easy.Constant;
using Easy.Extend;
using System.Text.RegularExpressions;
using ZKEACMS.FormGenerator.Models;

namespace ZKEACMS.FormGenerator.Service.Validator
{
    public class PhoneFormDataValidator : IFormDataValidator
    {
        private readonly ILocalize _localize;
        public PhoneFormDataValidator(ILocalize localize)
        {
            _localize = localize;
        }

        public bool Validate(FormField field, FormDataItem data, out string message)
        {
            message = string.Empty;
            if (field.Name == "Phone" && data.FieldValue.IsNotNullAndWhiteSpace())
            {
                if (Regex.IsMatch(data.FieldValue, RegularExpression.ChinesePhone) || Regex.IsMatch(data.FieldValue, RegularExpression.ChineseMobile))
                {
                    return true;
                }
                else
                {
                    message = _localize.Get("Invalid value for {0}.").FormatWith(field.DisplayName);
                    return false;
                }
            }
            return true;
        }
    }
}
