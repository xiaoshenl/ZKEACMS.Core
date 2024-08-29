/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy.Constant;
using Easy.RepositoryPattern;
using ZKEACMS.Extend;
using ZKEACMS.MetaData;
using ZKEACMS.Widget;

namespace ZKEACMS.Article.Models
{
    [DataTable("ArticleTypeWidget")]
    public class ArticleTypeWidget : BasicWidget
    {
        public int ArticleTypeID { get; set; }
        public string TargetPage { get; set; }
    }
    class ArticleTypeWidgetMetaData : WidgetMetaData<ArticleTypeWidget>
    {
        protected override void ViewConfigure()
        {
            base.ViewConfigure();
            ViewConfig(m => m.ArticleTypeID).AsDropDownList().Order(NextOrder()).SetTemplate("ArticleTypeTree").Required();
            ViewConfig(m => m.PartialView).AsDropDownList().Order(NextOrder()).DataSource(SourceType.Dictionary).AsWidgetTemplateChooser();
            ViewConfig(m => m.TargetPage).AsHidden();
        }
    }
}