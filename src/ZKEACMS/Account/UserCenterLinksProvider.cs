/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */
using System.Collections.Generic;

namespace ZKEACMS.Account
{
    public class UserCenterLinksProvider : IUserCenterLinksProvider
    {
        public IEnumerable<AdminMenu> GetLinks()
        {
            yield return new AdminMenu { Order = 20, Title = "Account Center", Url = "~/account" };
        }
    }
}
