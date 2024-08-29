/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Microsoft.AspNetCore.Authorization;

namespace Easy.Mvc.Authorize
{
    public class RolePolicyRequirement : IAuthorizationRequirement
    {
        public string Policy { get; set; }
    }
}
