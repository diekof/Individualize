using System;
using System.Collections.Generic;

namespace Individualize.Models
{
    public partial class Cidade
    {
        public Cidade()
        {
            Bairro = new HashSet<Bairro>();
        }

        public int CidadeId { get; set; }
        public string CidadeDsc { get; set; }
        public short? EstadoId { get; set; }

        public virtual Estado Estado { get; set; }
        public virtual ICollection<Bairro> Bairro { get; set; }
    }
}
