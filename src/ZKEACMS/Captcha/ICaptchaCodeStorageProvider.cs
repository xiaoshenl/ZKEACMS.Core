/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

namespace ZKEACMS.Captcha
{
    public interface ICaptchaCodeStorageProvider
    {
        void SaveCode(string code);
        string GetCode();
    }
}
