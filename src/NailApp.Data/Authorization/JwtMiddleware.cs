using NailApp.Data.Interfaces;

namespace NailApp.Data.Authorization
{
    public class JwtMiddleware
    {
        private readonly Microsoft.AspNetCore.Http.RequestDelegate _next;

        public JwtMiddleware(Microsoft.AspNetCore.Http.RequestDelegate next)
        {
            _next = next;
        }
        public async Task Invoke(Microsoft.AspNetCore.Http.HttpContext context, IUserRepository userService, IJwtUtils jwtUtils)
        {
            var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
            var userId = jwtUtils.ValidateJwtToken(token);
            if (userId != null)
            {
                // attach user to context on successful jwt validation
                context.Items["User"] = userService.GetUserById(userId.Value);
            }
            await _next(context);
        }
    }
}
