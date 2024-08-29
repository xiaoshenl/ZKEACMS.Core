/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using System.IO;

namespace Easy.Mvc.Plugin
{
    public class DependencyAssemblyResolver
    {
        public DependencyAssemblyResolver(string basePath)
        {
            BasePath = basePath;
        }
        public string BasePath { get; set; }
        public string[] ResolveAssemblyPaths()
        {
            return Directory.GetFiles(BasePath, "*.dll");
        }
    }
}
