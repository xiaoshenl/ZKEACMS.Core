/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using System.Collections.Generic;

namespace ZKEACMS
{
    public interface IAdminMenuProvider
    {
        IEnumerable<AdminMenu> GetAdminMenus();
    }
}
