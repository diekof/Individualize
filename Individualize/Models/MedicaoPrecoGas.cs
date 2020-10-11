using System;
using System.Collections.Generic;

namespace Individualize.Models
{
    public partial class MedicaoPrecoGas
    {
        public int MedicaoId { get; set; }
        public short MedicaoPrecoGasId { get; set; }
        public decimal MedicaoPrecoGasQtd { get; set; }
        public decimal MedicaoPrecoGasValor { get; set; }

        public virtual Medicao Medicao { get; set; }
    }
}
