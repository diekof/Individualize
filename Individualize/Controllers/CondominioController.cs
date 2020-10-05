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
            var condominios = await context.Condominio.ToListAsync();
            return condominios;
        }

        // [HttpGet]
        // [Route("{id:int}")]
        // public async Task<ActionResult<Condominio>> GetById([FromServices] DataContext context, int CondominioId)
        // {
        //     var condominio = await context.Condominios.Include(x => x.Fornecedor)
        //         .AsNoTracking()
        //         .FirstOrDefaultAsync(x => x.CondominioId == CondominioId);
        //     return condominio;
        // }

        // [HttpPost]
        // [Route("")]
        // public async Task<ActionResult<Condominio>> Post(
        //     [FromServices] DataContext context,
        //     [FromBody]Condominio model)
        // {
        //     if (ModelState.IsValid)
        //     {
        //         context.Condominios.Add(model);
        //         await context.SaveChangesAsync();
        //         return model;
        //     }
        //     else
        //     {
        //         return BadRequest(ModelState);
        //     }
        // }

        // [HttpDelete]
        // [Route("{id:int")]
        // public async Task<ActionResult<Condominio>> Del([FromServices] DataContext context, int CondominioId)
        // {
        //     context.Condominios.Remove.

        // }
    }

}
