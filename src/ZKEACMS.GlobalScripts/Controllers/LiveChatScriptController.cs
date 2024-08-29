/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy.Mvc.Authorize;
using ZKEACMS.Controllers;
using ZKEACMS.GlobalScripts.Models;
using ZKEACMS.Setting;

namespace ZKEACMS.GlobalScripts.Controllers
{
    [DefaultAuthorize(Policy = PermissionKeys.ManageLiveChatScript)]
    public class LiveChatScriptController : SettingController<LiveChatScript>
    {
        public LiveChatScriptController(IApplicationSettingService applicationSettingService) : base(applicationSettingService)
        {
        }
    }
}
