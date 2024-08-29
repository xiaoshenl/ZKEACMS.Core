/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using System.Threading.Tasks;

namespace ZKEACMS.PendingTask
{
    public interface IPendingTaskExecutor
    {
        Task ProcessAllPendingTaskAsync();
    }
}
