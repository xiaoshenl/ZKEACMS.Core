/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */


using Newtonsoft.Json;

namespace ZKEACMS.StructuredData
{
    public class Person : StructuredDataBase
    {
        public override string Type { get { return "Person"; } }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

    }
}
