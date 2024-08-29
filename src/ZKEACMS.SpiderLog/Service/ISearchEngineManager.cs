/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using System.Collections.Generic;
using ZKEACMS.SpiderLog.Models;

namespace ZKEACMS.SpiderLog.Service
{
    public interface ISearchEngineManager
    {
        SearchEngine Get(string userAgent);
        void Log(string name, string host, string url);
        IEnumerable<SearchEngineVisitLog> GetLastVisitLogs(string host);
        IEnumerable<SearchEngineVisitLog> GetVisitLogs(string name, string host);
    }
}
