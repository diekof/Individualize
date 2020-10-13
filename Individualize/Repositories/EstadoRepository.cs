using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

using Individualize.Data;
using Individualize.Interfaces;
using Individualize.Models;

using System.Linq.Expressions;
using System;
using System.Linq;

namespace Individualize.Repositories
{
    public class EstadoRepository : EfRepository<Estado>, IEstadoRepository
    {
        public EstadoRepository(DataContext dbbcontexto) : base(dbbcontexto)
        {
          
        }

       public IEnumerable<Estado> Listar(Estado Estado)
       {
           return base.Pesquisar(x => 
                (x.EstadoId==Estado.EstadoId || Estado.EstadoId != null) &&
                (EF.Functions.Like(x.EstadoDsc,'%'+Estado.EstadoDsc+'%') || string.IsNullOrEmpty(Estado.EstadoDsc))
            );           
       }
    }
}