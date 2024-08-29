/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy;
using Easy.Mvc.Resource;
using Easy.Mvc.Route;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using ZKEACMS.SiteSearch.Models;
using ZKEACMS.SiteSearch.Service;
using ZKEACMS.WidgetTemplate;

namespace ZKEACMS.SiteSearch
{
    public class SiteSearchPlug : PluginBase
    {
        public override IEnumerable<RouteDescriptor> RegistRoute()
        {
            return null;
        }

        public override IEnumerable<AdminMenu> AdminMenu()
        {
            return null;
        }

        protected override void InitScript(Func<string, ResourceHelper> script)
        {
            script("site-search").Include("~/Plugins/ZKEACMS.SiteSearch/Content/site-search.js", "~/Plugins/ZKEACMS.SiteSearch/Content/site-search.min.js");
        }

        protected override void InitStyle(Func<string, ResourceHelper> style)
        {
            style("site-search").Include("~/Plugins/ZKEACMS.SiteSearch/Content/site-search.css", "~/Plugins/ZKEACMS.SiteSearch/Content/site-search.min.css");
        }

        public override IEnumerable<PermissionDescriptor> RegistPermission()
        {
            return null;
        }

        public override IEnumerable<WidgetTemplateEntity> WidgetServiceTypes()
        {
            yield return new WidgetTemplateEntity<SiteSearchWidgetService>
            {
                Title = "Search Engine Search",
                GroupName = "6.Search",
                PartialView = "Widget.SiteSearch",
                Thumbnail = "~/Plugins/ZKEACMS.SiteSearch/Content/Widget.SiteSearch.png",
                Order = 1
            };
        }

        public override void ConfigureServices(IServiceCollection serviceCollection)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(CurrentPluginPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true).Build();

            serviceCollection.AddSingleton(configuration.GetSection("SearchEngines").Get<IEnumerable<SearchEngine>>());
            serviceCollection.ConfigureMetaData<SiteSearchWidget, SiteSearchWidgetMetaData>();
        }
    }
}