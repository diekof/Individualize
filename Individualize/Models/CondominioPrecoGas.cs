using System;
using System.Collections.Generic;

namespace Individualize.Models
{
    public partial class CondominioPrecoGas
    {
        public short CondominioId { get; set; }
        public short PrecoGasId { get; set; }
        public decimal PrecoGasQtd { get; set; }
        public decimal PrecoGasValor { get; set; }

        public virtual Condominio Condominio { get; set; }
    }
}
