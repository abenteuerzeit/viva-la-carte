using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using NuGet.Protocol;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using VLC.Data;
using VLC.Models.Recipes;
using VLC.Services;

namespace VLC.Controllers
{
    public class RecipesController : Controller
    {
        private readonly IRecipesService _service;
        private readonly IUnitOfWork _uow;
        private readonly UserManager<IdentityUser> _userManager;

        public RecipesController(IRecipesService service, IUnitOfWork uow, UserManager<IdentityUser> userManager)
        {
            _service = service;
            _uow = uow;
            _userManager = userManager;
        }

        [HttpPost]
        public async Task<IActionResult> SaveToCookBook([FromBody] Recipe recipe)
        {
            IdentityUser user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
                //return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }
            Task<Cookbook> cookbook = _service.AddToCookbook(recipe, user.Id);
            return Ok(cookbook.ToJson());
        }

        // GET: Recipes
        public async Task<IActionResult> Index()
        {
            var recipes = await _uow.RecipesRepo.GetAllAsync();

            return View(recipes);
        }

        // GET: Recipes/Details/5
        public async Task<IActionResult> Details(int id)
        {
            if (_uow == null)
            {
                return NotFound();
            }

            var recipe = await _uow.RecipesRepo.GetRecordByIdAsync(id);
            if (recipe == null)
            {
                return NotFound();
            }

            return View(recipe);
        }

        // GET: Recipes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Recipes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //[Bind(include: "Uri,Label,Image,Source,Url,ShareAs,Yield,Calories,TotalWeight,TotalTime,Id,Name,Instructions,Portions,PortionSize,PortionUnitOfMeasurment,Grams,AuthorId,PreperationTime,CookingTime,Rating,IsFavorite,ImageURL")]
        public async Task<IActionResult> Create(Hits hits)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _uow.RecipesRepo.InsertRecordAsync(hits);
                    await _uow.RecipesRepo.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return View(hits);
            
        }


        #region EDIT
        // GET: Recipes/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            if (_uow == null)
            {
                return NotFound();
            }

            var recipe = await _uow.RecipesRepo.GetRecordByIdAsync(id);
            await _uow.RecipesRepo.SaveChangesAsync();

            if (recipe == null)
            {
                return NotFound();
            }
            return View(recipe);
        }

        // POST: Recipes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Uri,Label,Image,Source,Url,ShareAs,Yield,Calories,TotalWeight,TotalTime,Id,Name,Instructions,Portions,PortionSize,PortionUnitOfMeasurment,Grams,AuthorId,PreperationTime,CookingTime,Rating,IsFavorite,ImageURL")] Hits hits)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _uow.RecipesRepo.UpdateRecord(hits);
                    await _uow.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
            }
            catch (DataException /* dex */)
            {
                ModelState.AddModelError(string.Empty, "Unable to save changes. Try again, and if the problem persists contact your system administrator.");
            }
            return RedirectToAction("Index");
        }
        #endregion

        // GET: Recipes/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            if (_uow == null)
            {
                return NotFound();
            }

            var recipe = await _uow.RecipesRepo.GetRecordByIdAsync(id);
            return View(recipe);
        }

        #region DELETE
        // POST: Recipes/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_uow == null)
            {
                return NotFound();
            }
            var recipe = await _uow.RecipesRepo.GetRecordByIdAsync(id);
            if (recipe != null)
            {
                await _uow.RecipesRepo.DeleteRecordAsync(id);
            }

            await _uow.RecipesRepo.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        #endregion


        //private bool RecipeExists(int id)
        //{
        //    return _context.Recipes.Any(e => e.Id == id);
        //}
    }
}
