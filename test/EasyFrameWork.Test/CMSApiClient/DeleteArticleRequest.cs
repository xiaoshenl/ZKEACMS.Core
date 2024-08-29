using Easy.Net.WebApi;
using System.Net.Http;

namespace EasyFrameWork.Test.CMSApiClient
{
    public class DeleteArticleRequest : HttpRequest, IAuthorizeRequired
    {
        public DeleteArticleRequest(int articleId) : base($"/api/article/delete/{articleId}", HttpMethod.Delete, typeof(void))
        {
        }
    }
}
