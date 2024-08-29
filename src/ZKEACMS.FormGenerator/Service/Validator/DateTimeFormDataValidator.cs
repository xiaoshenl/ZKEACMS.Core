/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy;
using Easy.Extend;
using System;
using ZKEACMS.FormGenerator.Models;

namespace ZKEACMS.FormGenerator.Service.Validator
{
    public class DateTimeFormDataValidator : IFormDataValidator
    {
        private readonly ILocalize _localize;
        public DateTimeFormDataValidator(ILocalize localize)
        {
            _localize = localize;
        }
        public bool Validate(FormField field, FormDataItem data, out string message)
        {
            message = string.Empty;
            DateTime dateTime;
            if (field.Name == "Date" && data.FieldValue.IsNotNullAndWhiteSpace() && !DateTime.TryParse(data.FieldValue, out dateTime))
            {
                message = _localize.Get("Invalid date value for {0}.").FormatWith(field.DisplayName);
                return false;
            }
            return true;
        }
    }
}
