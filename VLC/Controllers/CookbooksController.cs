using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VLC.Data;
using VLC.Models.Recipes;

namespace VLC.Controllers
{
    public class CookbooksController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CookbooksController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Cookbooks
        public async Task<IActionResult> Index()
        {
              return View(await _context.Cookbooks.ToListAsync());
        }

        // GET: Cookbooks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Cookbooks == null)
            {
                return NotFound();
            }

            var cookbook = await _context.Cookbooks
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cookbook == null)
            {
                return NotFound();
            }

            return View(cookbook);
        }

        // GET: Cookbooks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cookbooks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Label")] Cookbook cookbook)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cookbook);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cookbook);
        }

        // GET: Cookbooks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Cookbooks == null)
            {
                return NotFound();
            }

            var cookbook = await _context.Cookbooks.FindAsync(id);
            if (cookbook == null)
            {
                return NotFound();
            }
            return View(cookbook);
        }

        // POST: Cookbooks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Label")] Cookbook cookbook)
        {
            if (id != cookbook.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cookbook);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CookbookExists(cookbook.Id))
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
            return View(cookbook);
        }

        // GET: Cookbooks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Cookbooks == null)
            {
                return NotFound();
            }

            var cookbook = await _context.Cookbooks
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cookbook == null)
            {
                return NotFound();
            }

            return View(cookbook);
        }

        // POST: Cookbooks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Cookbooks == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Cookbooks'  is null.");
            }
            var cookbook = await _context.Cookbooks.FindAsync(id);
            if (cookbook != null)
            {
                _context.Cookbooks.Remove(cookbook);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CookbookExists(int id)
        {
          return _context.Cookbooks.Any(e => e.Id == id);
        }
    }
}
