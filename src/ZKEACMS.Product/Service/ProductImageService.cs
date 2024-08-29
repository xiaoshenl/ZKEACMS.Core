/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy;
using Easy.RepositoryPattern;
using ZKEACMS.Product.Models;

namespace ZKEACMS.Product.Service
{
    public class ProductImageService : ServiceBase<ProductImage, CMSDbContext>, IProductImageService
    {
        public ProductImageService(IApplicationContext applicationContext, CMSDbContext dbContext) : base(applicationContext, dbContext)
        {
        }
    }
}
