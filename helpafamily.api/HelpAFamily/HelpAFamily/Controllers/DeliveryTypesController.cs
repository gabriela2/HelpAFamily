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
    public class DeliveryTypesController : ControllerBase
    {
        private readonly DataContext _context;

        public DeliveryTypesController(DataContext context)
        {
            _context = context;
        }

        // GET: api/DeliveryTypes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DeliveryType>>> GetDeliveryTypes()
        {
            return await _context.DeliveryTypes.ToListAsync();
        }

        // GET: api/DeliveryTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DeliveryType>> GetDeliveryType(int id)
        {
            var deliveryType = await _context.DeliveryTypes.FindAsync(id);

            if (deliveryType == null)
            {
                return NotFound();
            }

            return deliveryType;
        }

        // PUT: api/DeliveryTypes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDeliveryType(int id, DeliveryType deliveryType)
        {
            if (id != deliveryType.Id)
            {
                return BadRequest();
            }

            _context.Entry(deliveryType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DeliveryTypeExists(id))
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

        // POST: api/DeliveryTypes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DeliveryType>> PostDeliveryType(DeliveryType deliveryType)
        {
            _context.DeliveryTypes.Add(deliveryType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDeliveryType", new { id = deliveryType.Id }, deliveryType);
        }

        // DELETE: api/DeliveryTypes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDeliveryType(int id)
        {
            var deliveryType = await _context.DeliveryTypes.FindAsync(id);
            if (deliveryType == null)
            {
                return NotFound();
            }

            _context.DeliveryTypes.Remove(deliveryType);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DeliveryTypeExists(int id)
        {
            return _context.DeliveryTypes.Any(e => e.Id == id);
        }
    }
}
