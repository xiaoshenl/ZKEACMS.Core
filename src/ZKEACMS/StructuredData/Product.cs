/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Newtonsoft.Json;

namespace ZKEACMS.StructuredData
{
    public class Product : StructuredDataContext
    {
        public override string Type { get { return "Product"; } }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("image")]
        public string[] Image { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("sku")]
        public string SKU { get; set; }

        [JsonProperty("mpn")]
        public string MPN { get; set; }

        [JsonProperty("brand")]
        public Brand Brand { get; set; }
    }
}
