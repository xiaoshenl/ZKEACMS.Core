/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy.RepositoryPattern;

namespace ZKEACMS.EventAction.Service
{
    public interface IActionBodyService : IService<Models.ActionBody>
    {
        string RenderBody(int ID, object model);
    }
}
