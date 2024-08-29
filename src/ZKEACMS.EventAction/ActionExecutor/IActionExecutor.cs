/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy.RepositoryPattern;
using ZKEACMS.Event;

namespace ZKEACMS.EventAction.ActionExecutor
{
    public interface IActionExecutor
    {
        ServiceResult Execute(Arguments args, object model, EventArg e);
    }
}
