/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy.Mvc.Authorize;
using Microsoft.AspNetCore.Mvc;

namespace ZKEACMS.StyleEditor.Controllers
{
    [DefaultAuthorize]
    public class StyleEditorController : Controller
    {
        public IActionResult Edit()
        {
            return View();
        }
    }
}
