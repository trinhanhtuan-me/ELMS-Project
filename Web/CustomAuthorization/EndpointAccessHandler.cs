using Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace Web.CustomAuthorization
{
    public class EndPointAccessRequirement : IAuthorizationRequirement
    {
    }

    public class EndPointAccessHandler(IFunctionRepository _functionRepository) : AuthorizationHandler<EndPointAccessRequirement>
    {
        protected override async Task HandleRequirementAsync(AuthorizationHandlerContext context, EndPointAccessRequirement requirement)
        {
            if (context.Resource is HttpContext httpContext)
            {
                var userIdRaw = httpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
                if (string.IsNullOrEmpty(userIdRaw) || !Guid.TryParse(userIdRaw, out Guid userId))
                {
                    context.Fail();
                    return;
                }

                var path = httpContext.Request.Path.Value;
                if (string.IsNullOrEmpty(path))
                {
                    context.Fail();
                    return;
                }
                var userFunction = await _functionRepository.FindUserFunctions(userId);
                bool hasPermission = userFunction.Any(f => f.PermissionKey != null
                    && path.StartsWith(f.PermissionKey, StringComparison.OrdinalIgnoreCase));

                if (hasPermission) context.Succeed(requirement);
                else context.Fail();
            }
        }
    }
}
