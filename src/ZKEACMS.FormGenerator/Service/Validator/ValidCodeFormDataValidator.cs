/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy;
using Easy.Extend;
using ZKEACMS.Captcha;
using ZKEACMS.FormGenerator.Models;

namespace ZKEACMS.FormGenerator.Service.Validator
{
    public class ValidCodeFormDataValidator : IFormDataValidator
    {
        private readonly ILocalize _localize;
        private readonly IImageCaptchaService _imageCaptchaService;
        public ValidCodeFormDataValidator(ILocalize localize, IImageCaptchaService imageCaptchaService)
        {
            _localize = localize;
            _imageCaptchaService = imageCaptchaService;
        }

        public bool Validate(FormField field, FormDataItem data, out string message)
        {
            message = string.Empty;
            if (field.Name == "ValidCode" && data.FieldValue.IsNotNullAndWhiteSpace())
            {
                if (!_imageCaptchaService.ValidateCode(data.FieldValue))
                {
                    message = _localize.Get("{0} is not correct.").FormatWith(field.DisplayName);
                    return false;
                }
            }
            return true;
        }
    }
}
