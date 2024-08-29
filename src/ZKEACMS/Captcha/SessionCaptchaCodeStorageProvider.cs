/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */


using Microsoft.AspNetCore.Http;
using System.Text;

namespace ZKEACMS.Captcha
{
    public class SessionCaptchaCodeStorageProvider : ICaptchaCodeStorageProvider
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private const string SessionKey = "ZKEACMS.Captcha.Codes";

        public SessionCaptchaCodeStorageProvider(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public string GetCode()
        {
            return _httpContextAccessor.HttpContext.Session.GetString(SessionKey);
        }

        public void SaveCode(string code)
        {
            _httpContextAccessor.HttpContext.Session.SetString(SessionKey, code);
        }
    }
}
