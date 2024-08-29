using Easy.Net.WebApi;
using System.Net.Http;

namespace EasyFrameWork.Test.CMSApiClient
{
    public class ArticleRequest : HttpRequest
    {
        public ArticleRequest(int articleId) : base($"/api/article/get/{articleId}", HttpMethod.Get, typeof(ArticleEntity))
        {
        }
    }
}
