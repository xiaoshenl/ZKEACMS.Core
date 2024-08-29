/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

namespace Easy.Net.WebApi
{
    public interface IRequestInjector
    {
        void Inject(HttpRequest request);
    }
}
