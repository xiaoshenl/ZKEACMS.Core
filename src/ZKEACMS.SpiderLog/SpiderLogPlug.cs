/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy.Mvc.Resource;
using Easy.Mvc.Route;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Collections.Generic;
using ZKEACMS.Dashboard;
using ZKEACMS.SpiderLog.Service;
using ZKEACMS.WidgetTemplate;

namespace ZKEACMS.SpiderLog
{
    public class SpiderLogPlug : PluginBase
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

        }

        protected override void InitStyle(Func<string, ResourceHelper> style)
        {

        }

        public override IEnumerable<PermissionDescriptor> RegistPermission()
        {
            return null;
        }

        public override IEnumerable<WidgetTemplateEntity> WidgetServiceTypes()
        {
            return null;
        }

        public override void ConfigureServices(IServiceCollection serviceCollection)
        {
            serviceCollection.TryAddSingleton<ISearchEngineService, SearchEngineService>();
            serviceCollection.TryAddScoped<ISearchEngineManager, SearchEngineManager>();
            serviceCollection.TryAddSingleton<ISpiderLogData, SpiderLogData>();
            serviceCollection.AddTransient<IDashboardPartDriveService, DashboardSpiderLogService>();

            serviceCollection.RegistEvent<SearchEngineRequestHandler>(Event.Events.OnPageExecuted);
        }
    }
}