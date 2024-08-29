/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using System.Collections.Generic;
using ZKEACMS.Product.Models;

namespace ZKEACMS.Product.ViewModel
{
    public class ProductGalleryWidgetViewModel
    {
        public string DetailPageUrl { get; set; }
        public IEnumerable<ProductEntity> Products { get; set; }
    }
}
