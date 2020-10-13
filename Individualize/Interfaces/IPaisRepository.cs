using System.Collections.Generic;
using Individualize.Models;

namespace Individualize.Interfaces
{
    public interface IPaisRepository : IRepository<Pais>
    {
         IEnumerable<Pais> Listar(Pais Pais);
    }
}