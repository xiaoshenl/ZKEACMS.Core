/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy.MetaData;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;

namespace Easy
{
    public static class ServiceLocator
    {
        private static IHttpContextAccessor HttpContextAccessor;
        private static IServiceProvider AppScopedServiceProvider;
        private static Type MetaDataType = typeof(ViewMetaData<>);
        public static void Setup(IServiceProvider serviceProvider)
        {
            HttpContextAccessor = serviceProvider.GetService<IHttpContextAccessor>();
            AppScopedServiceProvider = serviceProvider;
        }
        private static IServiceProvider GetServiceProvider()
        {
            if (HttpContextAccessor == null || HttpContextAccessor.HttpContext == null) return AppScopedServiceProvider;

            return HttpContextAccessor.HttpContext.RequestServices;
        }
        public static T GetService<T>()
        {
            return GetServiceProvider().GetService<T>();
        }
        public static IEnumerable<T> GetServices<T>()
        {
            return GetServiceProvider().GetServices<T>();
        }
        public static object GetService(Type type)
        {
            return GetServiceProvider().GetService(type);
        }
        public static IEnumerable<object> GetServices(Type type)
        {
            return GetServiceProvider().GetServices(type);
        }
        public static ViewConfigure GetViewConfigure(Type type)
        {
            if (type != null && HttpContextAccessor != null)
            {
                if (typeof(Microsoft.AspNetCore.Mvc.ControllerBase).IsAssignableFrom(type))
                {
                    return null;
                }
                var metaData = GetServiceProvider().GetService(MetaDataType.MakeGenericType(type)) as IViewMetaData;
                if (metaData != null)
                {
                    return new ViewConfigure(metaData);
                }
            }
            return null;
        }
    }
}