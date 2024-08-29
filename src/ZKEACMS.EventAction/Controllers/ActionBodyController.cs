/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy.Mvc.Authorize;
using Easy.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc;
using ZKEACMS.EventAction.Service;

namespace ZKEACMS.EventAction.Controllers
{
    [DefaultAuthorize(Policy = PermissionKeys.ViewNotificationContent)]
    public class ActionBodyController : BasicController<Models.ActionBody, int, IActionBodyService>
    {
        public ActionBodyController(IActionBodyService service) : base(service)
        {
        }

        [HttpPost, DefaultAuthorize(Policy = PermissionKeys.ManageNotificationContent)]
        public override IActionResult Edit(Models.ActionBody entity)
        {
            return base.Edit(entity);
        }

        [HttpPost, DefaultAuthorize(Policy = PermissionKeys.ManageNotificationContent)]
        public override IActionResult Create(Models.ActionBody entity)
        {
            return base.Create(entity);
        }

        [HttpPost, DefaultAuthorize(Policy = PermissionKeys.ManageNotificationContent)]
        public override IActionResult Delete(int id)
        {
            return base.Delete(id);
        }
    }
}
