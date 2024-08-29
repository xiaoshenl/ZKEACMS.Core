/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using LiteDB;
using System;

namespace ZKEACMS.SpiderLog.Models
{
    public class SearchEngineVisitLog
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public string Host { get; set; }
        public string Url { get; set; }
        public DateTime VisitAt { get; set; }
    }
}
