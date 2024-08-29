/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

namespace ZKEACMS.PendingTask
{
    public interface TaskEntity
    {
        string Identifier { get; set; }
        string HandlerName { get; set; }
        string Data { get; set; }
        int? Status { get; set; }
        string LogMessage { get; set; }
        int RetryCount { get; set; }
    }
}
