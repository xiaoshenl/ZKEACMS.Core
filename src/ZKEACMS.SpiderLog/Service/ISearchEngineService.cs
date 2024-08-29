/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using System.Collections.Generic;
using ZKEACMS.SpiderLog.Models;

namespace ZKEACMS.SpiderLog.Service
{
    public interface ISearchEngineService
    {
        IEnumerable<SearchEngine> Get();
        SearchEngine Get(string name);
    }
}
