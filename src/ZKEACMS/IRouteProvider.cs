/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy.Mvc.Route;
using System.Collections.Generic;

namespace ZKEACMS
{
    public interface IRouteProvider
    {
        IEnumerable<RouteDescriptor> GetRoutes();
    }
}
