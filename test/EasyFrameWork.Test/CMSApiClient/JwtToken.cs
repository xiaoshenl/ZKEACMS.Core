using Newtonsoft.Json;
using System;

namespace EasyFrameWork.Test.CMSApiClient
{
    public class JwtToken
    {
        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("expires")]
        public DateTime Expires { get; set; }
        public bool IsExpired
        {
            get
            {
                return DateTime.UtcNow > Expires;
            }
        }
    }
}
