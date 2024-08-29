/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using System.Net.Http.Headers;

namespace Easy.Net.WebApi
{
    public class GzipInjector : IRequestInjector
    {
        public void Inject(HttpRequest request)
        {
            request.Headers.AcceptEncoding.Add(new StringWithQualityHeaderValue("gzip"));
        }
    }
}
