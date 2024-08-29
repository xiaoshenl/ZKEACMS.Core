/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */


using Easy.MetaData;
using Easy.Models;

namespace ZKEACMS.Article.Models
{
    public class ArticleGalleryItem : EditorEntity
    {
        public ArticleItem Article { get; set; }
    }
    class ArticleGalleryItemMetaData : ViewMetaData<ArticleGalleryItem>
    {
        protected override void ViewConfigure()
        {
            ViewConfig(m => m.Title).AsHidden();
            ViewConfig(m => m.Description).AsHidden();
            ViewConfig(m => m.Article).AsArticleSelector();
        }
    }
}
