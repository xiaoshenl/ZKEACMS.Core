/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy.Mvc.Route;
using System.Collections.Generic;

namespace ZKEACMS
{
    public class RouteProvider : IRouteProvider
    {
        public IEnumerable<RouteDescriptor> GetRoutes()
        {
            foreach (var item in RouteDescriptors.Routes)
            {
                yield return item;
            }
        }
    }
}
