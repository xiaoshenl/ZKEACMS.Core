/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy.RepositoryPattern;
using ZKEACMS.Shop.Models;

namespace ZKEACMS.Shop.Service
{
    public interface IBasketService : IService<Basket>
    {
        Order CheckOut(Order order);
    }
}
