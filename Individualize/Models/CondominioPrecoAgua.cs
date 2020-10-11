using System;
using System.Collections.Generic;

namespace Individualize.Models
{
    public partial class CondominioPrecoAgua
    {
        public short CondominioId { get; set; }
        public short PrecoAguaId { get; set; }
        public decimal PrecoAguaQtd { get; set; }
        public decimal PrecoAguaValor { get; set; }

        public virtual Condominio Condominio { get; set; }
    }
}
