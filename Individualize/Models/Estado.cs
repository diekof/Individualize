using System;
using System.Collections.Generic;

namespace Individualize.Models
{
    public partial class Estado
    {
        public Estado()
        {
            Cidade = new HashSet<Cidade>();
        }

        public short EstadoId { get; set; }
        public string EstadoDsc { get; set; }
        public short PaisId { get; set; }
        public string EstadoSigla { get; set; }

        public virtual Pais Pais { get; set; }
        public virtual ICollection<Cidade> Cidade { get; set; }
    }
}
