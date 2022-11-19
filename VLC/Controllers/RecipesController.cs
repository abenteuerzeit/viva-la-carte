﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using NuGet.Protocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VLC.Data;
using VLC.Models.Recipes;
using VLC.Services;

namespace VLC.Controllers
{
    public class RecipesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IRecipesService _service;
        private readonly UserManager<IdentityUser> _userManager;

        public RecipesController(ApplicationDbContext context, IRecipesService service, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _service = service;
            _userManager = userManager;
        }

        // GET: Recipes
        public async Task<IActionResult> Index()
        {
            var recipes = await _context.Recipes.ToListAsync();

            return View(recipes);
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

        // GET: Recipes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Recipes == null)
            {
                return NotFound();
            }

            var recipe = await _context.Recipes
                .FirstOrDefaultAsync(m => m.Id == id);
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
        public async Task<IActionResult> Create([Bind("Uri,Label,Image,Source,Url,ShareAs,Yield,Calories,TotalWeight,TotalTime,Id,Name,Instructions,Portions,PortionSize,PortionUnitOfMeasurment,Grams,AuthorId,PreperationTime,CookingTime,Rating,IsFavorite,ImageURL")] Recipe recipe)
        {
            if (ModelState.IsValid)
            {
                _context.Add(recipe);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(recipe);
        }

        // GET: Recipes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Recipes == null)
            {
                return NotFound();
            }

            var recipe = await _context.Recipes.FindAsync(id);
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
        public async Task<IActionResult> Edit(int id, [Bind("Uri,Label,Image,Source,Url,ShareAs,Yield,Calories,TotalWeight,TotalTime,Id,Name,Instructions,Portions,PortionSize,PortionUnitOfMeasurment,Grams,AuthorId,PreperationTime,CookingTime,Rating,IsFavorite,ImageURL")] Recipe recipe)
        {
            if (id != recipe.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(recipe);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RecipeExists(recipe.Id))
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
            return View(recipe);
        }

        // GET: Recipes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Recipes == null)
            {
                return NotFound();
            }

            var recipe = await _context.Recipes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (recipe == null)
            {
                return NotFound();
            }

            return View(recipe);
        }

        // POST: Recipes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Recipes == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Recipes'  is null.");
            }
            var recipe = await _context.Recipes.FindAsync(id);
            if (recipe != null)
            {
                _context.Recipes.Remove(recipe);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RecipeExists(int id)
        {
            return _context.Recipes.Any(e => e.Id == id);
        }
    }
}
