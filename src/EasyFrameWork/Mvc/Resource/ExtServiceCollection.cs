/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Microsoft.Extensions.DependencyInjection;

namespace Easy.Mvc.Resource
{
    public static class ExtServiceCollection
    {
        public static void ConfigureResource<T>(this IServiceCollection serviceCollection) where T : ResourceManager
        {
            serviceCollection.AddTransient<ResourceManager, T>();
        }
    }
}
