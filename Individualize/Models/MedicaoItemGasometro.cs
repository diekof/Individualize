using System;
using System.Collections.Generic;

namespace Individualize.Models
{
    public partial class MedicaoItemGasometro
    {
        public int MedicaoId { get; set; }
        public int UnidadeId { get; set; }
        public int GasometroId { get; set; }
        public decimal MedicaoItemGasGasometro { get; set; }

        public virtual MedicaoItem MedicaoItem { get; set; }
        public virtual UnidadeGasometro UnidadeGasometro { get; set; }
    }
}
