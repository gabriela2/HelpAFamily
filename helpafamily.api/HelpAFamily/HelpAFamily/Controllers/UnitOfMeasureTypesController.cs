using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HelpAFamily;
using HelpAFamily.Models;

namespace HelpAFamily.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnitOfMeasureTypesController : Controller
    {
        private readonly DataContext _context;

        public UnitOfMeasureTypesController(DataContext context)
        {
            _context = context;
        }

        // GET: UnitOfMeasureTypes
        public async Task<IActionResult> Index()
        {
            return View(await _context.UnitOfMeasureTypes.ToListAsync());
        }

        // GET: UnitOfMeasureTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var unitOfMeasureType = await _context.UnitOfMeasureTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (unitOfMeasureType == null)
            {
                return NotFound();
            }

            return View(unitOfMeasureType);
        }

        // GET: UnitOfMeasureTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UnitOfMeasureTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description")] UnitOfMeasureType unitOfMeasureType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(unitOfMeasureType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(unitOfMeasureType);
        }

        // GET: UnitOfMeasureTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var unitOfMeasureType = await _context.UnitOfMeasureTypes.FindAsync(id);
            if (unitOfMeasureType == null)
            {
                return NotFound();
            }
            return View(unitOfMeasureType);
        }

        // POST: UnitOfMeasureTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description")] UnitOfMeasureType unitOfMeasureType)
        {
            if (id != unitOfMeasureType.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(unitOfMeasureType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UnitOfMeasureTypeExists(unitOfMeasureType.Id))
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
            return View(unitOfMeasureType);
        }

        // GET: UnitOfMeasureTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var unitOfMeasureType = await _context.UnitOfMeasureTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (unitOfMeasureType == null)
            {
                return NotFound();
            }

            return View(unitOfMeasureType);
        }

        // POST: UnitOfMeasureTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var unitOfMeasureType = await _context.UnitOfMeasureTypes.FindAsync(id);
            _context.UnitOfMeasureTypes.Remove(unitOfMeasureType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UnitOfMeasureTypeExists(int id)
        {
            return _context.UnitOfMeasureTypes.Any(e => e.Id == id);
        }
    }
}
