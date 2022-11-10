using VLC.Data;

namespace VLC.Services
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class MealManagerService : IMealManagerService
    {
        //private readonly RequestDelegate _next;
        private readonly ApplicationDbContext _context;
        private readonly IConfiguration _config;

        public MealManagerService(ApplicationDbContext context, IConfiguration config) // , RequestDelegate next)
        {
            _context = context;
            _config = config;
            //_next = next;
        }
        //public MealManagerService(RequestDelegate next)
        //{
        //    _next = next;
        //}

        //public Task Invoke(HttpContext httpContext)
        //{

        //    return _next(httpContext);
        //}


        /// <summary>
        ///     Searches the Edamam recipes database Application Programming Interface v2.
        ///     Documentation: https://developer.edamam.com/recipe-search-api-v2-changelog.
        /// </summary>
        /// <param name="search_query">
        ///     Provide a search phrase with escaped whitespace.
        /// </param>
        /// <returns>
        ///     URL string for Edamam Recipes Search API,
        ///     Example:"https://api.edamam.com/api/recipes/v2?q=scrambled%20eggs&app_id=54fe811b&app_key=3dc43f24bc09518326e7783ceb08d984&type=public"
        /// </returns>
        public string GetEdamamRecipesAPI_URL_For(string search_query)
        {
            string baseURL = "https://api.edamam.com/api/recipes/v2";
            string app_id = _config["EdamamRecipeSearch:app_id"];
            string app_key = _config["EdamamRecipeSearch:app_key"];
            string type = "public";
            return $"{baseURL}?q={search_query}&app_id={app_id}&app_key={app_key}&type={type}";
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
