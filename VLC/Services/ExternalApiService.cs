using System;
using NuGet.Protocol;
using VLC.Data.Migrations;

namespace VLC.Services
{
    public class ExternalApiService : IExternalApiService
    {
        private readonly IConfiguration _config;

        public ExternalApiService(IConfiguration config)
        {
            _config = config;
        }

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
        public string SearchByQuery(string search_query)
        {
            string baseURL = "https://api.edamam.com/api/recipes/v2";
            string app_id = _config["EdamamRecipeSearch:app_id"];
            string app_key = _config["EdamamRecipeSearch:app_key"];
            string type = "public";
            return $"{baseURL}?type={type}&q={search_query}&app_id={app_id}&app_key={app_key}";
        }


        public string Next20Recipes(string next)
        {
            return next;
        }
    }
}

