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
    public class DemandsController : Controller
    {
        private readonly DataContext _context;

        public DemandsController(DataContext context)
        {
            _context = context;
        }

        // GET: Demands
        public async Task<IActionResult> Index()
        {
            var dataContext = _context.Demands.Include(d => d.Ad).Include(d => d.DeliveryType).Include(d => d.User);
            return View(await dataContext.ToListAsync());
        }

        // GET: Demands/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var demand = await _context.Demands
                .Include(d => d.Ad)
                .Include(d => d.DeliveryType)
                .Include(d => d.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (demand == null)
            {
                return NotFound();
            }

            return View(demand);
        }

        // GET: Demands/Create
        public IActionResult Create()
        {
            ViewData["AdId"] = new SelectList(_context.Ads, "Id", "Id");
            ViewData["DeliveryTypeId"] = new SelectList(_context.DeliveryTypes, "Id", "Id");
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: Demands/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserId,AdId,CreatedAt,Quantity,DeliveryTypeId")] Demand demand)
        {
            if (ModelState.IsValid)
            {
                _context.Add(demand);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AdId"] = new SelectList(_context.Ads, "Id", "Id", demand.AdId);
            ViewData["DeliveryTypeId"] = new SelectList(_context.DeliveryTypes, "Id", "Id", demand.DeliveryTypeId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", demand.UserId);
            return View(demand);
        }

        // GET: Demands/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var demand = await _context.Demands.FindAsync(id);
            if (demand == null)
            {
                return NotFound();
            }
            ViewData["AdId"] = new SelectList(_context.Ads, "Id", "Id", demand.AdId);
            ViewData["DeliveryTypeId"] = new SelectList(_context.DeliveryTypes, "Id", "Id", demand.DeliveryTypeId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", demand.UserId);
            return View(demand);
        }

        // POST: Demands/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserId,AdId,CreatedAt,Quantity,DeliveryTypeId")] Demand demand)
        {
            if (id != demand.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(demand);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DemandExists(demand.Id))
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
            ViewData["AdId"] = new SelectList(_context.Ads, "Id", "Id", demand.AdId);
            ViewData["DeliveryTypeId"] = new SelectList(_context.DeliveryTypes, "Id", "Id", demand.DeliveryTypeId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", demand.UserId);
            return View(demand);
        }

        // GET: Demands/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var demand = await _context.Demands
                .Include(d => d.Ad)
                .Include(d => d.DeliveryType)
                .Include(d => d.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (demand == null)
            {
                return NotFound();
            }

            return View(demand);
        }

        // POST: Demands/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var demand = await _context.Demands.FindAsync(id);
            _context.Demands.Remove(demand);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DemandExists(int id)
        {
            return _context.Demands.Any(e => e.Id == id);
        }
    }
}
