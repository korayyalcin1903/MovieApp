using System.IO;

namespace MovieApp.AdminUI.Middlewares
{
    public class AuthMiddleware
    {
        private readonly RequestDelegate _next;

        public AuthMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var authToken = context.Session.GetString("AuthToken");
            var path = context.Request.Path.ToString().ToLower();

            if (authToken == null)
            {

                if (path.Contains("/auth/login") || path.Contains("/auth/register"))
                {
                    await _next(context); 
                    return;
                }

                context.Response.Redirect("/auth/login");
                return;
            } else {
                if (path.Contains("/auth/login") || path.Contains("/auth/register"))
                {
                    context.Response.Redirect("/");
                    return;
                }
            }

            await _next(context); 
        }
    }


}
