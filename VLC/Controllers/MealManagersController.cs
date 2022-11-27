using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.DotNet.MSIdentity.Shared;
using Microsoft.DotNet.Scaffolding.Shared.CodeModifier.CodeChange;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using NuGet.Packaging;
using NuGet.Protocol;
using RestSharp;
using RestSharp.Extensions;
using RestSharp.Serializers.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Web.Helpers;
using VLC.Data;
using VLC.Models.API;
using VLC.Models.MealManager;
using VLC.Models.Meals;
using VLC.Models.Recipes;
using VLC.Services;

namespace VLC.Controllers
{
    public class MealManagersController : Controller
    {
        static readonly HttpClient client = new();
        private readonly ApplicationDbContext _context;
        private readonly IConfiguration _config;
        private readonly IMealManagerService _mealManagerService;

        public MealManagersController(ApplicationDbContext context, IConfiguration config, IMealManagerService mealManagerService)
        {
            _context = context;
            _config = config;
            _mealManagerService = mealManagerService;
        }

        //[HttpGet("{search}")]
        //public async Task<ActionResult<IEnumerable<Hits>>> Search(string name, Recipe recipe)
        //{
        //    try
        //    {
        //        var result = await _mealManagerService.Search(name, recipe)
        //    }
        //}

        /// <summary>
        /// Action injection with FromServices
        /// </summary>
        /// <param name="service"></param>
        /// <returns></returns>
        // GET: MealManagers/SearchRecipesByQuery
        [HttpGet]
        public async Task<IActionResult> SearchRecipesByQuery(string query, [FromServices] IMealManagerService service)
        {
            // TODO: Fetch recipes by query and extract results.
            // TODO: Provide user with search results
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
                return View(hits); //View("RecipeSearchResults", hits);
            }
            catch (Exception err)
            {
                return BadRequest(err);
            }
        }

        // GET: MealManagers
        public async Task<IActionResult> Index() //async Task<IActionResult> Index()
        {

            //string recipesURL = _mealManagerService.GetEdamamRecipesAPI_URL_For("scrambled%20eggs");
            //return Redirect(recipesURL);
            //return View(await _context.MealManager.ToListAsync());

            List<MealManager> mealManagers = await _context.MealManagers.ToListAsync();
            return View(mealManagers);

        }

        // GET: MealManagers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.MealManagers == null)
            {
                return NotFound();
            }

            var mealManager = await _context.MealManagers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mealManager == null)
            {
                return NotFound();
            }

            return View(mealManager);
        }

        // GET: MealManagers/NewMealPlan/3
        public async Task<IActionResult> NewMealPlan(int id)
        {
            MealPlan mealPlan = await _context.FindMealPlanAsync(id);
            if (mealPlan == null)
            {
                return NotFound();
            }

            ViewData.Add("MealPlanId", mealPlan.Id);
            List<Recipe> recipeIds = mealPlan.Recipes;
            foreach (Recipe recipeId in recipeIds)
            {
            }


            return View(mealPlan);
        }


        // GET: MealManagers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MealManagers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TotalCalories,MealCount,Diet,Goal,MeasurementSystem,Height,Weight,Age,BodyFat,ActivityLevel")] MealManager mealManager)
        {
            try
            {
                
                if (ModelState.IsValid)
                {
                    //MealPlan mealPlan = _mealManagerService.GetMealPlan(mealManager);
                    _context.Add(mealManager);
                    //_context.Add(mealPlan);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                    //Ok(_context.MealPlans.ToList());  //RedirectToAction(nameof(Index));
                }
            } catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            return View(mealManager);
        }

        // GET: MealManagers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.MealManagers == null)
            {
                return NotFound();
            }

            var mealManager = await _context.MealManagers.FindAsync(id);
            await _context.SaveChangesAsync();

            if (mealManager == null)
            {
                return NotFound();
            }
            return View(mealManager);
        }

        // POST: MealManagers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TotalCalories,MealCount,Diet,Goal,MeasurementSystem,Height,Weight,Age,BodyFat,ActivityLevel")] MealManager mealManager)
        {
            if (id != mealManager.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mealManager);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MealManagerExists(mealManager.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(mealManager);
        }

        // GET: MealManagers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.MealManagers == null)
            {
                return NotFound();
            }

            var mealManager = await _context.MealManagers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mealManager == null)
            {
                return NotFound();
            }

            return View(mealManager);
        }

        // POST: MealManagers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.MealManagers == null)
            {
                return Problem("Entity set 'ApplicationDbContext.MealManagers'  is null.");
            }
            var mealManager = await _context.MealManagers.FindAsync(id);
            if (mealManager != null)
            {
                _context.MealManagers.Remove(mealManager);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MealManagerExists(int id)
        {
            return _context.MealManagers.Any(e => e.Id == id);
        }

    }
}
