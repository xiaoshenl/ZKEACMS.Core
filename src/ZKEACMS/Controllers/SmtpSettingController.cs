/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy.Mvc.Authorize;
using Easy.Notification;
using ZKEACMS.Setting;

namespace ZKEACMS.Controllers
{
    [DefaultAuthorize(Policy = PermissionKeys.SMTPSetting)]
    public class SmtpSettingController : SettingController<SmtpSetting>
    {
        public SmtpSettingController(IApplicationSettingService applicationSettingService) : base(applicationSettingService)
        {

        }
    }
}
