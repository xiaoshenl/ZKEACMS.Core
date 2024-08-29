/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using System.Collections.Generic;

namespace ZKEACMS.PendingTask
{
    public interface IPendingTaskService
    {
        void Add(string identifier, string handlerName, object context);
        void Complete(TaskEntity entity);
        void RetryLater(TaskEntity entity);
        void Fail(TaskEntity entity);
        IEnumerable<TaskEntity> GetPendingTasks();
    }
}
