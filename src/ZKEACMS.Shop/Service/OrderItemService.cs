/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy;
using Easy.RepositoryPattern;
using ZKEACMS.Shop.Models;

namespace ZKEACMS.Shop.Service
{
    public class OrderItemService : ServiceBase<OrderItem, CMSDbContext>, IOrderItemService
    {
        public OrderItemService(IApplicationContext applicationContext, CMSDbContext dbContext) : base(applicationContext, dbContext)
        {
        }

    }
}
