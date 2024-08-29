/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Newtonsoft.Json;

namespace ZKEACMS.StructuredData
{
    public abstract class StructuredDataContext : StructuredDataBase
    {
        [JsonProperty("@context")]
        public string Context { get { return "https://schema.org"; } }
    }
}
