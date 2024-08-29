/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy.RepositoryPattern;
using System.Collections.Generic;
using ZKEACMS.Article.Models;

namespace ZKEACMS.Article.Service
{
    public interface IArticleTypeService : IService<ArticleType>
    {
        IEnumerable<ArticleType> GetChildren(long id);
        ArticleType GetByUrl(string url);
    }
}