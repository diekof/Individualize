using System.Collections.Generic;
using Individualize.Models;

namespace Individualize.Interfaces
{
    public interface IEstadoRepository : IRepository<Estado>
    {
         IEnumerable<Estado> Listar(Estado Estado);
    }
}