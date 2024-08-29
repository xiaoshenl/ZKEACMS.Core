/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy;
using System;
using System.Collections.Generic;
using ZKEACMS.Sitemap.Models;
using ZKEACMS.Sitemap.Service;

namespace ZKEACMS.Product.Service
{
    public class ProductPageSiteUrlProvider : ISiteUrlProvider
    {
        private readonly IProductUrlService _productUrlService;

        public ProductPageSiteUrlProvider(IProductUrlService productUrlService)
        {
            _productUrlService = productUrlService;
        }

        public IEnumerable<SiteUrl> Get()
        {
            foreach (var item in _productUrlService.GetAllPublicUrls())
            {
                yield return new SiteUrl
                {
                    Url = Helper.Url.ToAbsolutePath(item.Url),
                    ModifyDate = item.Product.LastUpdateDate ?? DateTime.Now,
                    Changefreq = "weekly",
                    Priority = 0.5F
                };
            }
        }
    }
}
