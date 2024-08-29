/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Alipay.AopSdk.AspnetCore;
using Easy.Mvc.Authorize;
using ZKEACMS.Controllers;
using ZKEACMS.Setting;

namespace ZKEACMS.Shop.Controllers
{
    [DefaultAuthorize(Policy = PermissionKeys.PaymentConfigManage)]
    public class AliPaySettingController : SettingController<AlipayOptions>
    {
        public AliPaySettingController(IApplicationSettingService applicationSettingService) : base(applicationSettingService)
        {

        }
    }
}
