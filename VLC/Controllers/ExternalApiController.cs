using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Google.Apis.PeopleService.v1.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestSharp;
using VLC.Models.Recipes;
using VLC.Services;

namespace VLC.Controllers
{
    public class ExternalApiController : Controller
    {
        static readonly HttpClient client = new();
        private readonly IConfiguration _config;
        private readonly IMealManagerService _mealManagerService;

        public ExternalApiController(IConfiguration config, IMealManagerService mealManagerService)
        {
            _config = config;
            _mealManagerService = mealManagerService;
        }

        /// <summary>
        /// Action injection with FromServices
        /// </summary>
        /// <param name="service"></param>
        /// <returns></returns>
        // GET: MealManagers/SearchRecipesByQuery
        [HttpGet]
        public async Task<IActionResult> SearchRecipesByQuery(string query, [FromServices] IMealManagerService service)
        {
            Uri searchURL = new(service.GetEdamamRecipesAPI_URL_For(query));
            try
            {
                RestClient restClient = new RestClient(client);
                restClient.Options.MaxTimeout = 30;
                RestRequest request = new(searchURL) { AlwaysMultipartFormData = true };
                var cancellationTokenSource = new CancellationTokenSource();
                var response = await restClient.ExecuteAsync(request, cancellationTokenSource.Token);
                var res = string.IsNullOrWhiteSpace(response.Content) ? throw new TypeLoadException() : response.Content;
                var hits = Hits.FromJson(res);
                return View(hits);
            }
            catch (Exception err)
            {
                return BadRequest(err);
            }
        }

    }
}
