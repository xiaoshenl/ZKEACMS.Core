/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */


using Easy.MetaData;

namespace ZKEACMS.Article.Models
{
    public class ArticleItem
    {
        public string Title { get; set; }
        public int ArticleID { get; set; }
    }
    class ArticleGalleryProductMetaData : ViewMetaData<ArticleItem>
    {
        protected override void ViewConfigure()
        {
            ViewConfig(m => m.ArticleID).AsHidden().Required();
            ViewConfig(m => m.Title).AsTextBox().Required();
        }
    }
}
