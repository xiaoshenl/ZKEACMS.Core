/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy.RepositoryPattern;
using ZKEACMS.Extend;
using ZKEACMS.MetaData;
using ZKEACMS.Widget;

namespace ZKEACMS.Common.Models
{
    [DataTable("ImageWidget")]
    public class ImageWidget : BasicWidget
    {
        public string ImageUrl { get; set; }
        public string ImageUrlMd { get; set; }
        public string ImageUrlSm { get; set; }
        public int? Width { get; set; }
        public int? Height { get; set; }
        public string Link { get; set; }
        public string AltText { get; set; }
    }
    class ImageWidgetMedaData : WidgetMetaData<ImageWidget>
    {
        protected override void ViewConfigure()
        {
            base.ViewConfigure();
            ViewConfig(m => m.Title).AsHidden();
            ViewConfig(m => m.ImageUrl).AsTextBox().Required().Order(NextOrder()).MediaSelector();
            ViewConfig(m => m.ImageUrlMd).AsTextBox().Order(NextOrder()).MediaSelector();
            ViewConfig(m => m.ImageUrlSm).AsTextBox().Order(NextOrder()).MediaSelector();
        }
    }
}