using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

using Individualize.Data;
using Individualize.Interfaces;
using Individualize.Models;

namespace Individualize.Repositories
{
    public class PaisRepository : EfRepository<Pais>, IPaisRepository
    {
        public PaisRepository(DataContext dbbcontexto) : base(dbbcontexto)
        {
          
        }

       public IEnumerable<Pais> Listar(Pais Pais)
       {
           return base.Pesquisar(x => 
                (x.PaisId==Pais.PaisId || Pais.PaisId != null) &&
                (EF.Functions.Like(x.PaisDsc,'%'+Pais.PaisDsc+'%') || string.IsNullOrEmpty(Pais.PaisDsc))
            );           
       }
    }
}