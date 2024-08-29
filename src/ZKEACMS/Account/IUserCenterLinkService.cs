/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */
using System.Collections.Generic;

namespace ZKEACMS.Account
{
    public interface IUserCenterLinkService
    {
        IEnumerable<AdminMenu> GetLinks();
    }
}
