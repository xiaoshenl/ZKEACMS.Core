/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy.MetaData;

namespace ZKEACMS.Product.Models
{
    public class ProductItem
    {
        public string Title { get; set; }
        public int ProductID { get; set; }
    }
    class ProductGalleryProductMetaData : ViewMetaData<ProductItem>
    {
        protected override void ViewConfigure()
        {
            ViewConfig(m => m.ProductID).AsHidden().Required();
            ViewConfig(m => m.Title).AsTextBox().Required();
        }
    }
}
