/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy.Mvc;
using Easy.Mvc.Extend;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.DependencyInjection;

namespace ZKEACMS.Shop.Filter
{
    public class CustomLoginCheckAttribute : ActionFilterAttribute, IActionFilter
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.HttpContext.RequestServices.GetService<IApplicationContextAccessor>().Current.CurrentCustomer == null)
            {
                var location = (context.Controller as Controller).Url.Action("SignIn", "Account", new { ReturnUrl = context.HttpContext.Request.GetReferer() });
                context.Result = new JsonResult(new AjaxResult { Location = location, Status = AjaxStatus.Redirect });
            }
            else
            {
                base.OnActionExecuting(context);
            }
        }
    }
}
