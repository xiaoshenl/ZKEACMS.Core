/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using System;
using System.Collections.Generic;
using System.Reflection;

namespace Easy.Mvc.Plugin
{
    public class PluginDescriptor
    {
        public Type PluginType { get; set; }
        public Assembly Assembly { get; set; }
        public List<Assembly> Dependencies { get; set; }
        public string CurrentPluginPath { get; set; }
    }
}
