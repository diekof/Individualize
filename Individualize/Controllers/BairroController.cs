using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Individualize.Data;
using Individualize.Models;
using Individualize.Services.Commons;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace Individualize.Controllers
{
    [Route("v1/bairro")]
    [ApiController]
    [Authorize]
    public class BairroController : ControllerBase
    {
        private readonly DataContext _context;

        public BairroController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Bairro
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Bairro>>> GetBairro()
        {
            return await _context.Bairro.ToListAsync();
        }

        // GET: api/Bairro/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Bairro>> GetBairro(int id)
        {
            var bairro = await _context.Bairro.FindAsync(id);

            if (bairro == null)
            {
                return NotFound();
            }

            return bairro;
        }

        // PUT: api/Bairro/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBairro(int id, Bairro bairro)
        {
            if (id != bairro.BairroId)
            {
                return BadRequest();
            }

            _context.Entry(bairro).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BairroExists(id))
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

        // POST: api/Bairro
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Bairro>> PostBairro(Bairro bairro)
        {
            _context.Bairro.Add(bairro);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBairro", new { id = bairro.BairroId }, bairro);
        }

        // DELETE: api/Bairro/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Bairro>> DeleteBairro(int id)
        {
            var bairro = await _context.Bairro.FindAsync(id);
            if (bairro == null)
            {
                return NotFound();
            }

            _context.Bairro.Remove(bairro);
            await _context.SaveChangesAsync();

            return bairro;
        }

        private bool BairroExists(int id)
        {
            return _context.Bairro.Any(e => e.BairroId == id);
        }
    }
}
