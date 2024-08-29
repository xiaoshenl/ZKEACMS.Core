/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy.Extend;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System.IO;
using System.Linq;

namespace ZKEACMS
{
    public static class IWebHostEnvironmentExtend
    {
        private static string[] ToPathArray(string path)
        {
            return path.TrimStart('~').TrimStart('/').SplitWithDirectorySeparatorChar();
        }

        public static string MapPath(this IWebHostEnvironment env, string path)
        {
            return env.MapPath(ToPathArray(path));
        }

        public static string MapPath(this IWebHostEnvironment env, params string[] paths)
        {
            if (env.IsDevelopment() && paths[0] == Easy.Mvc.Plugin.Loader.PluginFolder)
            {
                return Path.Combine(new DirectoryInfo(env.ContentRootPath).Parent.FullName, Path.Combine(paths.Skip(1).ToArray()));
            }
            return Path.Combine(env.WebRootPath, Path.Combine(paths));
        }
    }
}
