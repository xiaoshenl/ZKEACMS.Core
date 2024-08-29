/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy;
using Easy.Constant;
using System.Linq;
using ZKEACMS.Extend;
using ZKEACMS.MetaData;
using ZKEACMS.Product.Service;
using ZKEACMS.Widget;

namespace ZKEACMS.Product.Models
{
    public class ProductGalleryWidget : SimpleWidgetBase
    {
        public string DetailPageUrl { get; set; }
        public int ProductGalleryId { get; set; }
    }
    class ProductGalleryWidgetMetaData : WidgetMetaData<ProductGalleryWidget>
    {
        protected override void ViewConfigure()
        {
            base.ViewConfigure();

            ViewConfig(m => m.DetailPageUrl).AsTextBox().Order(NextOrder()).PageSelector().InnerUrl();

            ViewConfig(m => m.ProductGalleryId).AsDropDownList()
                .Order(NextOrder())
                .Required()
                .DataSource(() =>
            {
                return ServiceLocator.GetService<IProductGalleryService>().Get(m => m.Status == (int)RecordStatus.Active).ToDictionary(m => m.ID.ToString(), m => m.Title);
            });
        }
    }

}
