using System;
using System.Collections.Generic;

namespace Individualize.Models
{
    public partial class MedicaoPrecoAgua
    {
        public int MedicaoId { get; set; }
        public short MedicaoPrecoAguaId { get; set; }
        public decimal MedicaoPrecoAguaQtd { get; set; }
        public decimal MedicaoPrecoAguaValor { get; set; }

        public virtual Medicao Medicao { get; set; }
    }
}
