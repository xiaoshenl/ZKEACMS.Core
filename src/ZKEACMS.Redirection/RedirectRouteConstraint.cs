/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using System;
using ZKEACMS.Redirection.Models;
using ZKEACMS.Redirection.Service;

namespace ZKEACMS.Redirection
{
    public class RedirectRouteConstraint : IRouteConstraint
    {
        public bool Match(HttpContext httpContext, IRouter route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
        {
            if (routeDirection == RouteDirection.UrlGeneration) return false;

            string path = $"~/{values[routeKey]}";
            if (path.Length > 2 && path.EndsWith('/'))
            {
                path = path.TrimEnd('/');
            }
            if (path.IndexOf(".html", StringComparison.OrdinalIgnoreCase) < 0 && CustomRegex.PostId().IsMatch(path))
            {
                return true;
            }
            UrlRedirect redirect = httpContext.RequestServices.GetService<IUrlRedirectService>().GetMatchedRedirection(path);

            return redirect != null;
        }
    }
}
