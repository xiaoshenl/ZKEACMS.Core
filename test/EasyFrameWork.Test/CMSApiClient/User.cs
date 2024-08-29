using Newtonsoft.Json;

namespace EasyFrameWork.Test.CMSApiClient
{
    public class User
    {
        [JsonProperty("userID")]
        public string UserId { get; set; }

        [JsonProperty("passWord")]
        public string Password { get; set; }
    }
}
