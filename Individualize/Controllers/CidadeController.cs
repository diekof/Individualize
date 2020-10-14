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
    [Route("v1/cidade")]
    [ApiController]
    [Authorize]
    public class CidadeController : ControllerBase
    {
        private readonly DataContext _context;

        public CidadeController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Cidade
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cidade>>> GetCidade()
        {
            return await _context.Cidade.ToListAsync();
        }

        // GET: api/Cidade/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Cidade>> GetCidade(int id)
        {
            var cidade = await _context.Cidade.FindAsync(id);

            if (cidade == null)
            {
                return NotFound();
            }

            return cidade;
        }

        // PUT: api/Cidade/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCidade(int id, Cidade cidade)
        {
            if (id != cidade.CidadeId)
            {
                return BadRequest();
            }

            _context.Entry(cidade).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CidadeExists(id))
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

        // POST: api/Cidade
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Cidade>> PostCidade(Cidade cidade)
        {
            _context.Cidade.Add(cidade);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCidade", new { id = cidade.CidadeId }, cidade);
        }

        // DELETE: api/Cidade/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Cidade>> DeleteCidade(int id)
        {
            var cidade = await _context.Cidade.FindAsync(id);
            if (cidade == null)
            {
                return NotFound();
            }

            _context.Cidade.Remove(cidade);
            await _context.SaveChangesAsync();

            return cidade;
        }

        private bool CidadeExists(int id)
        {
            return _context.Cidade.Any(e => e.CidadeId == id);
        }
    }
}
