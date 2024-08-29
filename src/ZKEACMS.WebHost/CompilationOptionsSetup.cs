/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy.Mvc.Plugin;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;

namespace ZKEACMS.WebHost
{
    public class CompilationOptionsSetup : ConfigureOptions<MvcRazorRuntimeCompilationOptions>
    {
        public CompilationOptionsSetup(IWebHostEnvironment webHostEnvironment) : base(optoins =>
        {
            if (webHostEnvironment.IsDevelopment())
            {
                optoins.FileProviders.Add(new DeveloperViewFileProvider(webHostEnvironment));
            }
        })
        {
        }
    }
}
