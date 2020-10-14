using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Individualize.Data;
using Individualize.Models;
using Microsoft.AspNetCore.Authorization;

namespace Individualize.Controllers
{
    [Route("v1/condominiotorres")]
    [ApiController]
    [Authorize]
    public class CondominoTorresController : ControllerBase
    {
        private readonly DataContext _context;

        public CondominoTorresController(DataContext context)
        {
            _context = context;
        }

        // GET: api/CondominoTorres
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CondominioTorres>>> GetCondominioTorres()
        {
            return await _context.CondominioTorres.ToListAsync();
        }

        // GET: api/CondominoTorres/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CondominioTorres>> GetCondominioTorres(short id)
        {
            var condominioTorres = await _context.CondominioTorres.FindAsync(id);

            if (condominioTorres == null)
            {
                return NotFound();
            }

            return condominioTorres;
        }

        // PUT: api/CondominoTorres/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCondominioTorres(short id, CondominioTorres condominioTorres)
        {
            if (id != condominioTorres.CondominioId)
            {
                return BadRequest();
            }

            _context.Entry(condominioTorres).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CondominioTorresExists(id))
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

        // POST: api/CondominoTorres
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<CondominioTorres>> PostCondominioTorres(CondominioTorres condominioTorres)
        {
            _context.CondominioTorres.Add(condominioTorres);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CondominioTorresExists(condominioTorres.CondominioId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCondominioTorres", new { id = condominioTorres.CondominioId }, condominioTorres);
        }

        // DELETE: api/CondominoTorres/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CondominioTorres>> DeleteCondominioTorres(short id)
        {
            var condominioTorres = await _context.CondominioTorres.FindAsync(id);
            if (condominioTorres == null)
            {
                return NotFound();
            }

            _context.CondominioTorres.Remove(condominioTorres);
            await _context.SaveChangesAsync();

            return condominioTorres;
        }

        private bool CondominioTorresExists(short id)
        {
            return _context.CondominioTorres.Any(e => e.CondominioId == id);
        }
    }
}
