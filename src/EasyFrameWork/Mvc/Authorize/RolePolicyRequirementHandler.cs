/* http://www.zkea.net/ 
 * Copyright (c) ZKEASOFT. All rights reserved. 
 * http://www.zkea.net/licenses */

using Microsoft.AspNetCore.Authorization;
using System.Threading.Tasks;

namespace Easy.Mvc.Authorize
{
    public class RolePolicyRequirementHandler : AuthorizationHandler<RolePolicyRequirement>
    {
        private readonly IAuthorizer _authorizer;
        public RolePolicyRequirementHandler(IAuthorizer authorizer)
        {
            _authorizer = authorizer;
        }
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, RolePolicyRequirement requirement)
        {
            if (context.User.Identity.IsAuthenticated)
            {
                if (_authorizer.Authorize(requirement.Policy))
                {
                    context.Succeed(requirement);
                }
                else
                {
                    context.Fail();
                }
            }
            else
            {
                context.Fail();
            }
            return Task.CompletedTask;
        }
    }
}
