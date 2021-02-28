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
    public class RoleTypesController : ControllerBase
    {
        private readonly DataContext _context;

        public RoleTypesController(DataContext context)
        {
            _context = context;
        }

        // GET: api/RoleTypes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RoleType>>> GetRoleTypes()
        {
            return await _context.RoleTypes.ToListAsync();
        }

        // GET: api/RoleTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RoleType>> GetRoleType(int id)
        {
            var roleType = await _context.RoleTypes.FindAsync(id);

            if (roleType == null)
            {
                return NotFound();
            }

            return roleType;
        }

        // PUT: api/RoleTypes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRoleType(int id, RoleType roleType)
        {
            if (id != roleType.Id)
            {
                return BadRequest();
            }

            _context.Entry(roleType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RoleTypeExists(id))
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

        // POST: api/RoleTypes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RoleType>> PostRoleType(RoleType roleType)
        {
            _context.RoleTypes.Add(roleType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRoleType", new { id = roleType.Id }, roleType);
        }

        // DELETE: api/RoleTypes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRoleType(int id)
        {
            var roleType = await _context.RoleTypes.FindAsync(id);
            if (roleType == null)
            {
                return NotFound();
            }

            _context.RoleTypes.Remove(roleType);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RoleTypeExists(int id)
        {
            return _context.RoleTypes.Any(e => e.Id == id);
        }
    }
}
