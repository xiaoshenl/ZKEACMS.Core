/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Easy.Mvc.ViewResult
{
    public class HttpNotFoundResult : StatusCodeResult
    {
        public HttpNotFoundResult() : base((int)HttpStatusCode.NotFound)
        {
        }
    }
}
