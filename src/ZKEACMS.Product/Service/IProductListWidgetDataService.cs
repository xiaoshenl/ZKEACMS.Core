/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy.RepositoryPattern;
using ZKEACMS.Product.Models;

namespace ZKEACMS.Product.Service
{
    public interface IProductListWidgetDataService : IService<ProductListWidget>
    {
        void UpdateDetailPageUrl(string oldUrl, string newUrl);
    }
}
