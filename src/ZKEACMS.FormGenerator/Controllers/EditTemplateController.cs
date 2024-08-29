/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */


using Easy.Mvc.Authorize;
using Microsoft.AspNetCore.Mvc;

namespace ZKEACMS.FormGenerator.Controllers
{
    [DefaultAuthorize]
    public class EditTemplateController : Controller
    {
        public IActionResult TemplateView(string template)
        {
            return PartialView(template);
        }
    }
}
