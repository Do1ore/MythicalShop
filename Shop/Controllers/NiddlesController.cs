using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Shop.Data;
using Shop.Models;

namespace Shop.Controllers
{
    public class NiddlesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public NiddlesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Niddles
        public async Task<IActionResult> Index()
        {
            return View(await _context.Niddles.ToListAsync());
        }

        // GET: Niddles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var niddle = await _context.Niddles
                .FirstOrDefaultAsync(m => m.Id == id);
            if (niddle == null)
            {
                return NotFound();
            }

            return View(niddle);
        }

        // GET: Niddles/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Niddles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description,Img")] Niddle niddle)
        {
            if (ModelState.IsValid)
            {
                _context.Add(niddle);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(niddle);
        }

        // GET: Niddles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var niddle = await _context.Niddles.FindAsync(id);
            if (niddle == null)
            {
                return NotFound();
            }
            return View(niddle);
        }

        // POST: Niddles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description,Img")] Niddle niddle)
        {
            if (id != niddle.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(niddle);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NiddleExists(niddle.Id))
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
            return View(niddle);
        }

        // GET: Niddles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var niddle = await _context.Niddles
                .FirstOrDefaultAsync(m => m.Id == id);
            if (niddle == null)
            {
                return NotFound();
            }

            return View(niddle);
        }

        // POST: Niddles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var niddle = await _context.Niddles.FindAsync(id);
            _context.Niddles.Remove(niddle);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NiddleExists(int id)
        {
            return _context.Niddles.Any(e => e.Id == id);
        }
    }
}
