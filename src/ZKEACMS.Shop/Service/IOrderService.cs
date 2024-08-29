/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy.RepositoryPattern;
using ZKEACMS.Shop.Models;

namespace ZKEACMS.Shop.Service
{
    public interface IOrderService : IService<Order>
    {
        void BeginPay(Order order);
        void CompletePay(Order order, string paymentGateway, string paymentID);

        PaymentInfo GetPaymentInfo(string orderId);
        ServiceResult<bool> Refund(string orderId, decimal amount, string reason);
        RefundInfo GetRefund(string orderId);
        ServiceResult<bool> CloseOrder(string orderId);
    }
}
