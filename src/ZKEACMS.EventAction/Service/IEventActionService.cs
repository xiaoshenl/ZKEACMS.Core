/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy.RepositoryPattern;
using System.Collections.Generic;
using ZKEACMS.EventAction.ActionExecutor;

namespace ZKEACMS.EventAction.Service
{
    public interface IEventActionService : IService<Models.EventAction>
    {
        Dictionary<string, List<EventActionContent>> GetAllActivedActinosFromCache();
    }
}
