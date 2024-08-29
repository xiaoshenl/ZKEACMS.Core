/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy.RepositoryPattern;
using ZKEACMS.Product.Models;

namespace ZKEACMS.Product.Service
{
    public interface IProductApiService
    {
        ProductEntity Get(int id);
        ProductEntity GetByName(string name);
        ServiceResult<ProductEntity> Create(ProductEntity product);
        ServiceResult<ProductEntity> Update(ProductEntity product);
        ProductEntity Publish(int id);
        void Delete(int id);
    }
}
