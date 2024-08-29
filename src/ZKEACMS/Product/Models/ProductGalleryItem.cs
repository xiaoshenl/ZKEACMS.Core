/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy.MetaData;
using Easy.Models;

namespace ZKEACMS.Product.Models
{
    public class ProductGalleryItem : EditorEntity
    {
        public ProductItem Product { get; set; }
    }
    class ProductGalleryItemMetaData : ViewMetaData<ProductGalleryItem>
    {
        protected override void ViewConfigure()
        {
            ViewConfig(m => m.Title).AsHidden();
            ViewConfig(m => m.Description).AsHidden();
            ViewConfig(m => m.Product).AsProductSelector();
        }
    }
}
