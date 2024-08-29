/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy.RepositoryPattern;
using ZKEACMS.Article.Models;

namespace ZKEACMS.Article.Service
{
    public interface IArticleApiService
    {
        ArticleEntity Get(int id);
        ArticleEntity GetByName(string name);
        ServiceResult<ArticleEntity> Create(ArticleEntity article);
        ServiceResult<ArticleEntity> Update(ArticleEntity article);
        ArticleEntity Publish(int id);
        void Delete(int id);
    }
}
