/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy.RepositoryPattern;
using System.Collections.Generic;
using ZKEACMS.Redirection.Models;

namespace ZKEACMS.Redirection.Service
{
    public interface IUrlRedirectService : IService<UrlRedirect>
    {
        IEnumerable<UrlRedirect> GetAll();
        UrlRedirect GetMatchedRedirection(string path);
    }
}
