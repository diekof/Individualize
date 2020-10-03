using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Individualize.Data;
using Individualize.Models;

namespace Individualize.Controllers
{
    [ApiController]
    [Route("v1/pessoas")]
    public class PessoaController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Pessoa>>> Get([FromServices] DataContext context)
        {
            var pessoas = await context.Pessoas.ToListAsync();
            return pessoas;
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Pessoa>> Post(
            [FromServices] DataContext context,
            [FromBody] Pessoa model)
        {
            if (ModelState.IsValid)
            {
                context.Pessoas.Add(model);
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
