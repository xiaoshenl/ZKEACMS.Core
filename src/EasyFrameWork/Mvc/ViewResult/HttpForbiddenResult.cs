/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Easy.Mvc.ViewResult
{
    public class HttpForbiddenResult : StatusCodeResult
    {
        public HttpForbiddenResult() : base((int)HttpStatusCode.Forbidden)
        {
        }
    }
}
