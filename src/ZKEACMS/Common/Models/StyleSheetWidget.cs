/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy.RepositoryPattern;
using ZKEACMS.Extend;
using ZKEACMS.MetaData;
using ZKEACMS.Widget;

namespace ZKEACMS.Common.Models
{
    [DataTable("StyleSheetWidget")]
    public class StyleSheetWidget : BasicWidget
    {
        public string StyleSheet { get; set; }
    }

    class StyleSheetWidgetMetaData : WidgetMetaData<StyleSheetWidget>
    {
        protected override void ViewConfigure()
        {
            base.ViewConfigure();
            ViewConfig(m => m.PartialView).AsHidden();
            ViewConfig(m => m.Title).AsHidden();
            ViewConfig(m => m.StyleClass).AsHidden();
            ViewConfig(m => m.StyleSheet).AsTextArea().AsCodeEditor("css").Order(NextOrder()).Required();
        }
    }
}