/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using System.Collections.Generic;
using ZKEACMS.Product.Models;

namespace ZKEACMS.Product.Service
{
    public interface IProductUrlService
    {
        string[] GetPublicUrl(int ID);
        string[] GetPublicUrl(ProductEntity product);
        IEnumerable<ProductUrl> GetAllPublicUrls();
        string[] GetDetailPages();
    }
}
