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
    [ApiController]
    [Authorize]
    [Route("v1/estado")]
    public class EstadoController : ControllerBase
    {

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<Estado>> GetById([FromServices] DataContext context,
                                                     int id)
        {
            
            var v = await context.Estado
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.EstadoId == id);

            return v;
        }

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Estado>>> Get([FromServices] DataContext context)
        {
            var v = await context.Estado.ToListAsync();
            return v;
        }
        
        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Estado>> Post(
            [FromServices] DataContext context,
            [FromBody] Estado model)
        {
            if (ModelState.IsValid)
            {
                context.Estado.Add(model);
                await context.SaveChangesAsync();
                return model;
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<ActionResult<Estado>> Delete([FromServices] DataContext context,
                                                     int id,
                                                     bool? saveChangesError = false)
        {
            if (id == null)
                return NotFound();

            try{
                var v = await context.Estado
                                        .AsNoTracking()
                                        .FirstOrDefaultAsync(x => x.EstadoId == id);
                context.Estado.Remove(v);
                await context.SaveChangesAsync();
                return Ok();
            }catch (DbUpdateException /* ex */){
                return BadRequest(ModelState);
            }
            
        }
    }
}