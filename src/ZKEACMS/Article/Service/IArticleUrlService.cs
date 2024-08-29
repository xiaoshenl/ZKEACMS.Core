/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using System.Collections.Generic;
using ZKEACMS.Article.Models;

namespace ZKEACMS.Article.Service
{
    public interface IArticleUrlService
    {
        string[] GetPublicUrl(int ID);
        string[] GetPublicUrl(ArticleEntity article);
        IEnumerable<ArticleUrl> GetAllPublicUrls();
        string[] GetDetailPages();
    }
}
