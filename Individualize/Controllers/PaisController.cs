using System;
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
    [Route("v1/pais")]
    public class PaisController : ControllerBase
    {

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<Pais>> GetById([FromServices] DataContext context,
                                                     int id)
        {
            
            var pais = await context.Pais
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.PaisId == id);

            return pais;
        }

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Pais>>> Get([FromServices] DataContext context)
        {
            var pais = await context.Pais.ToListAsync();
            return pais;
        }
        
        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Pais>> Post(
            [FromServices] DataContext context,
            [FromBody] Pais model)
        {
            if (ModelState.IsValid)
            {
                context.Pais.Add(model);
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
        public async Task<ActionResult<Pais>> Delete([FromServices] DataContext context,
                                                     int id,
                                                     bool? saveChangesError = false)
        {
            if (id == null)
                return NotFound();

            try{
                var pais = await context.Pais
                                        .AsNoTracking()
                                        .FirstOrDefaultAsync(x => x.PaisId == id);
                context.Pais.Remove(pais);
                await context.SaveChangesAsync();
                return Ok();
            }catch (Exception ex){
                // _logger.LogError($"Something went wrong inside DeleteOwner action: {ex.Message}");
                return BadRequest();
                
            }
            
        }

    }
}