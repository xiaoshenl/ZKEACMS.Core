/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using System;

namespace ZKEACMS.Shop.Models
{
    public class PaymentInfo
    {
        public string Account { get; set; }
        public string TradeStatus { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime PayDate { get; set; }

        public string Body { get; set; }
    }
}
