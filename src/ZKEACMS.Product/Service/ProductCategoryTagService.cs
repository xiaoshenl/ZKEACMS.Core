/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy;
using Easy.RepositoryPattern;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using ZKEACMS.Product.Models;

namespace ZKEACMS.Product.Service
{
    public class ProductCategoryTagService : ServiceBase<ProductCategoryTag, CMSDbContext>, IProductCategoryTagService
    {
        private readonly IProductTagService _productTagService;
        public ProductCategoryTagService(IApplicationContext applicationContext, IProductTagService productTagService, CMSDbContext dbContext) : base(applicationContext, dbContext)
        {
            _productTagService = productTagService;
        }

        public override void Remove(ProductCategoryTag item)
        {
            BeginTransaction(() =>
            {
                _productTagService.Remove(m => m.TagId == item.ID);
                base.Remove(item);

                var children = LoadChildren(item);
                var ids = children.Select(m => m.ID).ToArray();
                _productTagService.Remove(m => ids.Contains(m.TagId));
                RemoveRange(children.ToArray());

            });
        }
        private IEnumerable<ProductCategoryTag> LoadChildren(ProductCategoryTag tag)
        {
            List<ProductCategoryTag> result = new List<ProductCategoryTag>();
            var children = Get(m => m.ParentId == tag.ID);
            result.AddRange(children);
            foreach (var item in children)
            {
                result.AddRange(LoadChildren(item));
            }
            return result;
        }
        public override void Remove(Expression<Func<ProductCategoryTag, bool>> filter)
        {
            BeginTransaction(() =>
            {
                var tags = Get(filter);
                var ids = tags.Select(m => m.ID).ToArray();
                _productTagService.Remove(m => ids.Contains(m.TagId));
                RemoveRange(tags.ToArray());
                foreach (var item in tags)
                {
                    var children = LoadChildren(item);
                    var childIds = children.Select(m => m.ID).ToArray();
                    _productTagService.Remove(m => ids.Contains(m.TagId));
                    RemoveRange(children.ToArray());
                }
            });
        }
    }
}
