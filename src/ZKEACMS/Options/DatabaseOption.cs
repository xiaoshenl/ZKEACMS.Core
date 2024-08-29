/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy;

namespace ZKEACMS.Options
{
    public class DatabaseOption
    {
        public DbTypes DbType { get; set; }
        public string ConnectionString { get; set; }
        public bool IsLowerCaseTableNames { get; set; }
    }
}
