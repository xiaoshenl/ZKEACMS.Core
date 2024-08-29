/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ZKEACMS
{
    public interface IDBContextProvider
    {
        DbContext Current { get; }
        IEnumerable<DbContext> GetAvailableDbContexts();
    }
}
