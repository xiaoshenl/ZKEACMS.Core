/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy;
using Easy.RepositoryPattern;
using System.Linq;
using ZKEACMS.Product.Models;

namespace ZKEACMS.Product.Service
{
    public class ProductListWidgetDataService : ServiceBase<ProductListWidget>, IProductListWidgetDataService
    {
        public ProductListWidgetDataService(IApplicationContext applicationContext, CMSDbContext dbContext) : base(applicationContext, dbContext)
        {
        }

        public void UpdateDetailPageUrl(string oldUrl, string newUrl)
        {
            var widgets = Get(m => m.DetailPageUrl == oldUrl || m.DetailPageUrl.StartsWith(oldUrl + "/"));
            foreach (var item in widgets)
            {
                item.DetailPageUrl = newUrl + item.DetailPageUrl.Substring(oldUrl.Length);
            }
            UpdateRange(widgets.ToArray());
        }
    }
}
