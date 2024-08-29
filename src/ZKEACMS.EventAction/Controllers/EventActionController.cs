/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy.Mvc.Authorize;
using Easy.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Text;
using ZKEACMS.EventAction.Service;

namespace ZKEACMS.EventAction.Controllers
{
    [DefaultAuthorize(Policy = PermissionKeys.ViewEventNotification)]
    public class EventActionController : BasicController<Models.EventAction, int, IEventActionService>
    {
        public EventActionController(IEventActionService service) : base(service)
        {
        }

        [HttpPost, DefaultAuthorize(Policy = PermissionKeys.ManageEventNotification)]
        public override IActionResult Edit(Models.EventAction entity)
        {
            return base.Edit(entity);
        }

        [DefaultAuthorize(Policy = PermissionKeys.ManageEventNotification)]
        public override IActionResult Create()
        {
            return View(new Models.EventAction
            {
                Actions = System.IO.File.ReadAllText(Path.Combine(PluginBase.GetPath<EventActionPlug>(), "example.yml"), Encoding.UTF8)
            });
        }

        [HttpPost, DefaultAuthorize(Policy = PermissionKeys.ManageEventNotification)]
        public override IActionResult Create(Models.EventAction entity)
        {
            return base.Create(entity);
        }

        [HttpPost, DefaultAuthorize(Policy = PermissionKeys.ManageEventNotification)]
        public override IActionResult Delete(int id)
        {
            return base.Delete(id);
        }
    }
}
