/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy;
using Easy.Extend;
using System;
using ZKEACMS.FormGenerator.Models;

namespace ZKEACMS.FormGenerator.Service.Validator
{
    public class NumberFormDataValidator : IFormDataValidator
    {
        private readonly ILocalize _localize;
        public NumberFormDataValidator(ILocalize localize)
        {
            _localize = localize;
        }
        public bool Validate(FormField field, FormDataItem data, out string message)
        {
            message = string.Empty;
            decimal result;
            if (field.Name == "Number" && data.FieldValue.IsNotNullAndWhiteSpace() && !Decimal.TryParse(data.FieldValue, out result))
            {
                message = _localize.Get("Invalid Number for {0}.").FormatWith(field.DisplayName);
                return false;
            }
            return true;
        }
    }
}
