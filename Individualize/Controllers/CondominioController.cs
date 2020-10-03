using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Individualize.Data;
using Individualize.Models;

namespace Individualize.Controllers
{
    [ApiController]
    [Route("v1/condominios")]
    public class CondominioController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Condominio>>> Get([FromServices] DataContext context)
        {
            var condominios = await context.Condominios.ToListAsync();
            return condominios;
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<List<Condominio>>> Get([FromServices] DataContext context)
        {
            var condominios = await context.Condominios.ToListAsync();
            return condominios;
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Condominio>> Post(
            [FromServices] DataContext context,
            [FromBody]Condominio model)
        {
            if (ModelState.IsValid)
            {
                context.Condominios.Add(model);
                await context.SaveChangesAsync();
                return model;
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
    }

}
