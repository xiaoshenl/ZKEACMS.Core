/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy.RepositoryPattern;
using System.Threading.Tasks;

namespace ZKEACMS.PendingTask
{
    public interface IPendingTaskHandler<out T>
    {
        Task<ServiceResult<string>> ExecuteAsync(object context);
        T Deserialize(string rowData);
    }
}
