using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Individualize.Data;
using Individualize.Models;
using Individualize.Services.Commons;
using Microsoft.AspNetCore.Authorization;

namespace Individualize.Controllers
{
    [Route("v1/condominio")]
    [ApiController]
    [Authorize]
    public class CondominioController : ControllerBase
    {
        private readonly DataContext _context;

        public CondominioController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Condominio
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Condominio>>> GetCondominio()
        {
            return await _context.Condominio.ToListAsync();
        }

        // GET: api/Condominio/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Condominio>> GetCondominio(short id)
        {
            var condominio = await _context.Condominio.FindAsync(id);

            if (condominio == null)
            {
                return NotFound();
            }

            return condominio;
        }

        // PUT: api/Condominio/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCondominio(short id, Condominio condominio)
        {
            if (id != condominio.CondominioId)
            {
                return BadRequest();
            }

            _context.Entry(condominio).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CondominioExists(id))
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

        // POST: api/Condominio
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Condominio>> PostCondominio(Condominio condominio)
        {
            _context.Condominio.Add(condominio);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCondominio", new { id = condominio.CondominioId }, condominio);
        }

        // DELETE: api/Condominio/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Condominio>> DeleteCondominio(short id)
        {
            var condominio = await _context.Condominio.FindAsync(id);
            if (condominio == null)
            {
                return NotFound();
            }

            _context.Condominio.Remove(condominio);
            await _context.SaveChangesAsync();

            return condominio;
        }

        private bool CondominioExists(short id)
        {
            return _context.Condominio.Any(e => e.CondominioId == id);
        }
    }
}
