/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Easy.Mvc.ViewResult
{
    public class HttpBadRequestResult : StatusCodeResult
    {
        public HttpBadRequestResult() : base((int)HttpStatusCode.BadRequest)
        {
        }
    }
}
