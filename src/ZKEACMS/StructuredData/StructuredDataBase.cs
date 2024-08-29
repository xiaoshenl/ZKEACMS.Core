using Newtonsoft.Json;

namespace ZKEACMS.StructuredData
{
    public abstract class StructuredDataBase
    {
        [JsonProperty("@type")]
        public abstract string Type { get; }
    }
}
