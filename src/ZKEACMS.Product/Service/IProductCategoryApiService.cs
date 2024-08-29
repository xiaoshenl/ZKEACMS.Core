/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy.RepositoryPattern;
using ZKEACMS.Product.Models;

namespace ZKEACMS.Product.Service
{
    public interface IProductCategoryApiService
    {
        ProductCategory Get(int id);
        ProductCategory GetByName(string name);
        ServiceResult<ProductCategory> Create(ProductCategory productCategory);
        ServiceResult<ProductCategory> Update(ProductCategory productCategory);
        void Delete(int id);
    }
}
