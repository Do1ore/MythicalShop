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
    public class RocksController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RocksController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Rocks
        public async Task<IActionResult> Index()
        {
            return View(await _context.Rocks.ToListAsync());
        }

        // GET: Rocks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rock = await _context.Rocks
                .FirstOrDefaultAsync(m => m.Id == id);
            if (rock == null)
            {
                return NotFound();
            }

            return View(rock);
        }

        // GET: Rocks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Rocks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description,Img")] Rock rock)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rock);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(rock);
        }

        // GET: Rocks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rock = await _context.Rocks.FindAsync(id);
            if (rock == null)
            {
                return NotFound();
            }
            return View(rock);
        }

        // POST: Rocks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description,Img")] Rock rock)
        {
            if (id != rock.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rock);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RockExists(rock.Id))
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
            return View(rock);
        }

        // GET: Rocks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rock = await _context.Rocks
                .FirstOrDefaultAsync(m => m.Id == id);
            if (rock == null)
            {
                return NotFound();
            }

            return View(rock);
        }

        // POST: Rocks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rock = await _context.Rocks.FindAsync(id);
            _context.Rocks.Remove(rock);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RockExists(int id)
        {
            return _context.Rocks.Any(e => e.Id == id);
        }
    }
}
