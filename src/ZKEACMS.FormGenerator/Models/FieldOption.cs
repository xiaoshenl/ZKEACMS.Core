/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy.Extend;
using Newtonsoft.Json;
using System;

namespace ZKEACMS.FormGenerator.Models
{
    public class FieldOption
    {
        public string DisplayText { get; set; }
        private string _value;
        public string Value
        {
            get
            {
                if (_value.IsNullOrEmpty())
                {
                    _value = Guid.NewGuid().ToString("N");
                }
                return _value;
            }
            set { _value = value; }
        }
        [JsonIgnore]
        public bool? Selected { get; set; }
    }
}
