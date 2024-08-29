/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

namespace ZKEACMS.EventAction.ActionExecutor
{
    public interface IExecutorManager
    {
        IActionExecutor CreateExecutor(string name);
    }
}
