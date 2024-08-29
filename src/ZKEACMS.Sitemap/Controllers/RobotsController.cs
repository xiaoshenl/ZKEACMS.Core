/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Microsoft.AspNetCore.Mvc;
using ZKEACMS.Common.Models;
using ZKEACMS.Setting;

namespace ZKEACMS.Sitemap.Controllers
{
    public class RobotsController : Controller
    {
        private readonly IApplicationSettingService _applicationSettingService;
        public RobotsController(IApplicationSettingService applicationSettingService)
        {
            _applicationSettingService = applicationSettingService;
        }
        public IActionResult Index()
        {
            return Content(_applicationSettingService.Get<Robots>().Content, "text/plain");
        }
    }
}
