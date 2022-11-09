using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VLC.Data;
using VLC.Models.MealManager;

namespace VLC.Controllers
{
    public class MealManagersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MealManagersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MealManagers
        public async Task<IActionResult> Index()
        {
              return View(await _context.MealManager.ToListAsync());
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
