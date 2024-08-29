using Easy.Net.WebApi;
using System.Net.Http;

namespace EasyFrameWork.Test.CMSApiClient
{
    public class TokenRequest : HttpRequest
    {
        public TokenRequest(CMSApiEnvironment environment) : base("/api/acount/createtoken", HttpMethod.Post, typeof(JwtToken))
        {
            ContentType = MimeContentType.Json;
            Body = new User
            {
                UserId = environment.Username,
                Password = environment.Password
            };
        }
    }
}
