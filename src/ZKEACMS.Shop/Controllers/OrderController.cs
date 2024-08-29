/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy.Mvc.Authorize;
using Easy.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc;
using ZKEACMS.Shop.Models;
using ZKEACMS.Shop.Service;

namespace ZKEACMS.Shop.Controllers
{
    [DefaultAuthorize(Policy = PermissionKeys.ViewOrder)]
    public class OrderController : BasicController<Order, string, IOrderService>
    {
        public OrderController(IOrderService service) : base(service)
        {
        }
        [NonAction]
        public override IActionResult Create()
        {
            return base.Create();
        }
        [HttpPost, NonAction]
        public override IActionResult Create(Order entity)
        {
            return base.Create(entity);
        }
        [DefaultAuthorize(Policy = PermissionKeys.ManageOrder)]
        public override IActionResult Edit(string Id)
        {
            return base.Edit(Id);
        }
        [HttpPost, DefaultAuthorize(Policy = PermissionKeys.ManageOrder)]
        public override IActionResult Edit(Order entity)
        {
            return base.Edit(entity);
        }
        [HttpPost, DefaultAuthorize(Policy = PermissionKeys.ManageOrder)]
        public override IActionResult Delete(string id)
        {
            return base.Delete(id);
        }
        [HttpPost, DefaultAuthorize(Policy = PermissionKeys.ViewOrderPayment)]
        public IActionResult PaymentInfo(string id)
        {
            return PartialView(Service.GetPaymentInfo(id));
        }
        [HttpPost, DefaultAuthorize(Policy = PermissionKeys.RefundOrder)]
        public IActionResult Refund(string id, decimal amount, string reason)
        {
            return Json(Service.Refund(id, amount, reason));
        }
        [HttpPost, DefaultAuthorize(Policy = PermissionKeys.ViewOrderRefund)]
        public IActionResult RefundInfo(string id)
        {
            return PartialView(Service.GetRefund(id));
        }
        //[HttpPost, DefaultAuthorize(Policy = PermissionKeys.CloseOrder)]
        //public IActionResult CloseOrder(string id)
        //{
        //    return Json(Service.CloseOrder(id));
        //}
    }
}
