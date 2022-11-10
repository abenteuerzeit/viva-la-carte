namespace VLC.Services
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class MealManagerService
    {
        private readonly RequestDelegate _next;

        public MealManagerService(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext)
        {

            return _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class MiddleExtensions
    {
        public static IApplicationBuilder UseMiddle(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<MealManagerService>();
        }
    }
}
