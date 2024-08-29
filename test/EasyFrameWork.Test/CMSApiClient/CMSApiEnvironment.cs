using Easy.Net.WebApi;

namespace EasyFrameWork.Test.CMSApiClient
{
    public class CMSApiEnvironment : ApiEnvironment
    {
        public CMSApiEnvironment(string username, string password)
        {
            BaseUrl = "http://demo.zkea.net/";
            Username = username;
            Password = password;
        }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
