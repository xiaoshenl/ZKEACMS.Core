/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy.Mvc.Authorize;
using ZKEACMS.Controllers;
using ZKEACMS.GlobalScripts.Models;
using ZKEACMS.Setting;

namespace ZKEACMS.GlobalScripts.Controllers
{
    [DefaultAuthorize(Policy = PermissionKeys.ManageStatisticsScript)]
    public class StatisticsScriptController : SettingController<StatisticsScript>
    {
        public StatisticsScriptController(IApplicationSettingService applicationSettingService) : base(applicationSettingService)
        {
        }
    }
}
