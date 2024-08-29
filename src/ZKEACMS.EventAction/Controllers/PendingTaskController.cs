/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy.Constant;
using Easy.Mvc.Authorize;
using Easy.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc;
using ZKEACMS.EventAction.Service;

namespace ZKEACMS.EventAction.Controllers
{
    [DefaultAuthorize(Policy = PermissionKeys.ViewEventNotification)]
    public class PendingTaskController : BasicController<Models.PendingTaskEntity, int, IPendingTaskManagerService>
    {
        public PendingTaskController(IPendingTaskManagerService service) : base(service)
        {
        }

        [HttpPost, DefaultAuthorize(Policy = PermissionKeys.ManageEventNotification)]
        public override IActionResult Edit(Models.PendingTaskEntity entity)
        {
            entity.RetryCount = 0;
            entity.Status = (int)RecordStatus.Active;
            entity.LogMessage = null;
            return base.Edit(entity);
        }

        [HttpPost, DefaultAuthorize(Policy = PermissionKeys.ManageEventNotification)]
        public override IActionResult Create(Models.PendingTaskEntity entity)
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
