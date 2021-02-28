using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HelpAFamily;
using HelpAFamily.Models;

namespace HelpAFamily.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnitOfMeasureTypesController : ControllerBase
    {
        private readonly DataContext _context;

        public UnitOfMeasureTypesController(DataContext context)
        {
            _context = context;
        }

        // GET: api/UnitOfMeasureTypes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UnitOfMeasureType>>> GetUnitOfMeasureTypes()
        {
            return await _context.UnitOfMeasureTypes.ToListAsync();
        }

        // GET: api/UnitOfMeasureTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UnitOfMeasureType>> GetUnitOfMeasureType(int id)
        {
            var unitOfMeasureType = await _context.UnitOfMeasureTypes.FindAsync(id);

            if (unitOfMeasureType == null)
            {
                return NotFound();
            }

            return unitOfMeasureType;
        }

        // PUT: api/UnitOfMeasureTypes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUnitOfMeasureType(int id, UnitOfMeasureType unitOfMeasureType)
        {
            if (id != unitOfMeasureType.Id)
            {
                return BadRequest();
            }

            _context.Entry(unitOfMeasureType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UnitOfMeasureTypeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/UnitOfMeasureTypes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<UnitOfMeasureType>> PostUnitOfMeasureType(UnitOfMeasureType unitOfMeasureType)
        {
            _context.UnitOfMeasureTypes.Add(unitOfMeasureType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUnitOfMeasureType", new { id = unitOfMeasureType.Id }, unitOfMeasureType);
        }

        // DELETE: api/UnitOfMeasureTypes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUnitOfMeasureType(int id)
        {
            var unitOfMeasureType = await _context.UnitOfMeasureTypes.FindAsync(id);
            if (unitOfMeasureType == null)
            {
                return NotFound();
            }

            _context.UnitOfMeasureTypes.Remove(unitOfMeasureType);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UnitOfMeasureTypeExists(int id)
        {
            return _context.UnitOfMeasureTypes.Any(e => e.Id == id);
        }
    }
}
