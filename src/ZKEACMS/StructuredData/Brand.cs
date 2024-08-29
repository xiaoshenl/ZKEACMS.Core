/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Newtonsoft.Json;

namespace ZKEACMS.StructuredData
{
    public class Brand : StructuredDataBase
    {
        public override string Type { get { return "Brand"; } }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
