using Easy.Net.WebApi;

namespace EasyFrameWork.Test.CMSApiClient
{
    public class CMSApiClient : ApiClient
    {
        public CMSApiClient(CMSApiEnvironment environment) : base(environment)
        {
            AddInjector(new AuthorizeInjector(environment));
        }
    }
}
