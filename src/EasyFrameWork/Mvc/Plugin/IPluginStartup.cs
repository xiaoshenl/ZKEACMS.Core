/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Reflection;

namespace Easy.Mvc.Plugin
{
    public interface IPluginStartup
    {
        Assembly Assembly { get; set; }
        List<Assembly> Dependencies { get; set; }
        string CurrentPluginPath { get; set; }
        void Setup(params object[] args);
        void ConfigureServices(IServiceCollection services);
        void ConfigureApplication(IApplicationBuilder app, IWebHostEnvironment env);
    }
}
