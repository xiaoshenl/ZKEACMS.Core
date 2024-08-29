/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Easy.Models;

namespace Easy.Mvc.Authorize
{
    public interface IAuthorizer
    {
        bool Authorize(string permission);
        bool Authorize(string permission, IUser user);
    }
}