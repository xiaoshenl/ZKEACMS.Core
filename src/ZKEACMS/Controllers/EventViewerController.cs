/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy.Mvc.Authorize;
using Microsoft.AspNetCore.Mvc;
using ZKEACMS.Common.Service;

namespace ZKEACMS.Controllers
{
    [DefaultAuthorize(Policy = PermissionKeys.ManageEventViewer)]
    public class EventViewerController(IEventViewerService eventViewerService) : Controller
    {
        private readonly IEventViewerService _eventViewerService = eventViewerService;

        public IActionResult Index()
        {
            return View(_eventViewerService.Get());
        }
        public IActionResult Delete(string id)
        {
            _eventViewerService.Delete(id);
            return Json(true);
        }

        public IActionResult ViewLog(string id, long? position)
        {
            return View(_eventViewerService.Take(id, position ?? 0, 20));
        }

        public IActionResult Download(string id)
        {
            return File(_eventViewerService.GetStream(id), "text/plain", id);
        }
    }
}
