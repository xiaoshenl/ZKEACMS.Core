/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using System;
using System.ComponentModel.DataAnnotations;

namespace Easy.ViewPort.Validator
{
    public class CustomValidationHandler : RequiredAttribute
    {
        private readonly Func<object, bool> _isValid;
        public CustomValidationHandler(Func<object, bool> isValid)
        {
            _isValid = isValid;
        }
        public override bool IsValid(object value)
        {
            return _isValid(value);
        }
    }
}
