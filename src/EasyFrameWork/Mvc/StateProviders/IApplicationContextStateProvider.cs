/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using System;

namespace Easy.Mvc.StateProviders
{
    public interface IApplicationContextStateProvider
    {
        string Name { get; }
        Func<IApplicationContext, T> Get<T>();
    }
}
