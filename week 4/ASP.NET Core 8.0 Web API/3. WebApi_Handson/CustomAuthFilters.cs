using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Authorization;

namespace CustomEmployeeAPI.Filters
{
    public class CustomAuthFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        { 
        var isAnonymousAllowed = context.ActionDescriptor.EndpointMetadata
                                          .Any(meta => meta is AllowAnonymousAttribute);
            if (isAnonymousAllowed)
            {
                base.OnActionExecuting(context);
                return;
            }
            if (!context.HttpContext.Request.Headers.TryGetValue("Authorization", out var token))
            {
                context.Result = new BadRequestObjectResult("Invalid request - No Auth token");
                return;
            }
            if (!token.ToString().Contains("Bearer"))
            {
                context.Result = new BadRequestObjectResult("Invalid request - Token present but Bearer unavailable");
                return;
            }
            base.OnActionExecuting(context);
        }
    }
}
