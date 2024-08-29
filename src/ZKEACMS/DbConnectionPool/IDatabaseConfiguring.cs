/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace ZKEACMS.DbConnectionPool
{
    public interface IDatabaseConfiguring
    {
        void OnConfiguring(DbContextOptionsBuilder optionsBuilder, DbConnection dbConnectionForReusing);
    }
}
