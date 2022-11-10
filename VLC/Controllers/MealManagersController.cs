﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.DotNet.MSIdentity.Shared;
using Microsoft.DotNet.Scaffolding.Shared.CodeModifier.CodeChange;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using NuGet.Protocol;
using RestSharp;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Helpers;
using VLC.Data;
using VLC.Models.API;
using VLC.Models.MealManager;
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
        /// <summary>
        /// Action injection with FromServices
        /// </summary>
        /// <param name="service"></param>
        /// <returns></returns>
        // GET: MealManagers/SearchRecipesByQuery
        [HttpGet]
        public IActionResult SearchRecipesByQuery(string query, [FromServices] IMealManagerService service)
        {
            // TODO: Fetch recipes by query and extract results.
            // TODO: Provide user with search results
            Uri searchURL = new(service.GetEdamamRecipesAPI_URL_For(query));
            try
            {
                RestClient restClient = new RestClient(client);
                restClient.Options.MaxTimeout = 30;
                RestRequest request = new(searchURL) { AlwaysMultipartFormData = true };
                JsonResult response = Json(restClient.Execute(request));
                return Ok(response);
            }
            catch (Exception err)
            {
                Console.Write($"\nException {nameof(err)} caught!");
                Console.WriteLine(err);
                return BadRequest();
            }
        }

        // GET: MealManagers
        public IActionResult Index() //async Task<IActionResult> Index()
        {
            string recipesURL = _mealManagerService.GetEdamamRecipesAPI_URL_For("scrambled%20eggs");
            return Redirect(recipesURL); // View(await _context.MealManager.ToListAsync());
        }

        // GET: MealManagers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.MealManager == null)
            {
                return NotFound();
            }

            var mealManager = await _context.MealManager
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mealManager == null)
            {
                return NotFound();
            }

            return View(mealManager);
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
            if (ModelState.IsValid)
            {
                mealManager.Age = 20;
                _context.Add(mealManager);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mealManager);
        }

        // GET: MealManagers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.MealManager == null)
            {
                return NotFound();
            }

            var mealManager = await _context.MealManager.FindAsync(id);
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
            if (id == null || _context.MealManager == null)
            {
                return NotFound();
            }

            var mealManager = await _context.MealManager
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
            if (_context.MealManager == null)
            {
                return Problem("Entity set 'ApplicationDbContext.MealManager'  is null.");
            }
            var mealManager = await _context.MealManager.FindAsync(id);
            if (mealManager != null)
            {
                _context.MealManager.Remove(mealManager);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MealManagerExists(int id)
        {
            return _context.MealManager.Any(e => e.Id == id);
        }

    }
}
