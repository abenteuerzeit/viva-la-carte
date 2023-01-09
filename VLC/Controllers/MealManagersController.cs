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
using System.Data;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Web.Helpers;
using VLC.Data;
using VLC.Models.API;
using VLC.Models.MealManager;
using VLC.Models.Meals;
using VLC.Models.Recipes;
using VLC.Repository;
using VLC.Services;

namespace VLC.Controllers
{
    public class MealManagersController : Controller
    {
        
        private readonly IConfiguration _config;
        private readonly IMealManagerService _mealManagerService;
        private readonly IUnitOfWork _uow;

        //public MealManagersController(ApplicationDbContext context, IConfiguration config, IMealManagerService mealManagerService)
        public MealManagersController(IConfiguration config, IMealManagerService mealManagerService, IUnitOfWork uow)
        {
            _config = config;
            _mealManagerService = mealManagerService;
            _uow = uow;
        }


        // GET: MealManagers
        public async Task<IActionResult> Index()
        {
            var mealManagers = await _uow.MealManagerRepo.GetAllAsync();
            return View(mealManagers);
        }

        // GET: MealManagers/Details/5
        public async Task<IActionResult> Details(int id)
        {
            if (_uow == null)
            {
                return NotFound();
            }

            var mealManager = await _uow.MealManagerRepo.GetRecordByIdAsync(id);
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
        public async Task<IActionResult> Create([Bind(include: "Id,TotalCalories,MealCount,Diet,Goal,MeasurementSystem,Height,Weight,Age,BodyFat,ActivityLevel")] MealManager mealManager)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    //MealPlan mealPlan = _mealManagerService.GetMealPlan(mealManager);
                    await _uow.MealManagerRepo.InsertRecordAsync(mealManager);
                    //_context.Add(mealPlan);
                    await _uow.MealManagerRepo.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                    //Ok(_context.MealPlans.ToList());  //RedirectToAction(nameof(Index));
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return View(mealManager);
        }


        #region EDIT
        // GET: MealManagers/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            if (_uow.MealManagerRepo == null)
            {
                return NotFound();
            }

            var mealManager = await _uow.MealManagerRepo.GetRecordByIdAsync(id);
            await _uow.MealManagerRepo.SaveChangesAsync();

            if(mealManager == null)
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
        public async Task<IActionResult>Edit([Bind(include: "Id,TotalCalories,MealCount,Diet,Goal,MeasurementSystem,Height,Weight,Age,BodyFat,ActivityLevel")] MealManager mealManager)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _uow.MealManagerRepo.UpdateRecord(mealManager);
                    await _uow.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
            }
            catch (DataException /* dex */)
            {
                //Log the error (uncomment dex variable name after DataException and add a line here to write a log.
                ModelState.AddModelError(string.Empty, "Unable to save changes. Try again, and if the problem persists contact your system administrator.");
            }
            return RedirectToAction("Index");

        }
        #endregion

        #region DELETE
        public async Task<IActionResult> Delete(int id)
        {
            if (_uow.MealManagerRepo == null)
            {
                return NotFound();
            }

            var mealManager = await _uow.MealManagerRepo.GetRecordByIdAsync(id);
            return View(mealManager);
        }
        #endregion

        #region DELETE CONFIRMED
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if(_uow.MealManagerRepo == null)
            {
                return NotFound();
            }

            var mealManager = await _uow.MealManagerRepo.GetRecordByIdAsync(id);
            if(mealManager != null)
            {
                await _uow.MealManagerRepo.DeleteRecordAsync(id);
            }
            await _uow.MealManagerRepo.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        #endregion


        //// GET: MealManagers/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null || _context.MealManagers == null)
        //    {
        //        return NotFound();
        //    }

        //    var mealManager = await _context.MealManagers
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (mealManager == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(mealManager);
        //}

        //// POST: MealManagers/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    if (_context.MealManagers == null)
        //    {
        //        return Problem("Entity set 'ApplicationDbContext.MealManagers'  is null.");
        //    }
        //    var mealManager = await _context.MealManagers.FindAsync(id);
        //    if (mealManager != null)
        //    {
        //        _context.MealManagers.Remove(mealManager);
        //    }

        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool MealManagerExists(int id)
        //{
        //    return _context.MealManagers.Any(e => e.Id == id);
        //}

        //// GET: MealManagers/NewMealPlan/3
        //public async Task<IActionResult> NewMealPlan(int id)
        //{
        //    MealPlan mealPlan = await _context.FindMealPlanAsync(id);
        //    if (mealPlan == null)
        //    {
        //        return NotFound();
        //    }

        //    ViewData.Add("MealPlanId", mealPlan.Id);
        //    List<Recipe> recipeIds = mealPlan.Recipes;
        //    foreach (Recipe recipeId in recipeIds)
        //    {
        //    }


        //    return View(mealPlan);
        //}

    }
}
