/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ZKEACMS
{
    public class ApplicationContextAccessor : IApplicationContextAccessor
    {
        private readonly IServiceProvider _serviceProvider;
        public ApplicationContextAccessor(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        private CMSApplicationContext current;
        public CMSApplicationContext Current
        {
            get
            {
                return current ?? (current = _serviceProvider.GetService<IApplicationContext>().CurrentAppContext());
            }
        }
    }
}
