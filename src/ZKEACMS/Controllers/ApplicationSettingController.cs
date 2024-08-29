/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy.Mvc.Authorize;
using Easy.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc;
using ZKEACMS.Setting;

namespace ZKEACMS.Controllers
{
    [DefaultAuthorize(Policy = PermissionKeys.ViewApplicationSetting)]
    public class ApplicationSettingController : BasicController<ApplicationSetting, string, IApplicationSettingService>
    {
        public ApplicationSettingController(IApplicationSettingService service)
            : base(service)
        {

        }
        [HttpPost, DefaultAuthorize(Policy = PermissionKeys.ManageApplicationSetting)]
        public override IActionResult Create(ApplicationSetting entity)
        {
            return base.Create(entity);
        }
        [HttpPost, DefaultAuthorize(Policy = PermissionKeys.ManageApplicationSetting)]
        public override IActionResult Edit(ApplicationSetting entity)
        {
            return base.Edit(entity);
        }
        [HttpPost, DefaultAuthorize(Policy = PermissionKeys.ManageApplicationSetting)]
        public override IActionResult Delete(string id)
        {
            return base.Delete(id);
        }
    }
}
