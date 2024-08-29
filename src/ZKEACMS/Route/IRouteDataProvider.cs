/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Microsoft.AspNetCore.Routing;

namespace ZKEACMS.Route
{
    public interface IRouteDataProvider
    {
        int Order { get; }
        string ExtractVirtualPath(string path, RouteValueDictionary values);
    }
}
