using System;
using System.Collections.Generic;

namespace Individualize.Models
{
    public partial class UnidadeGasometro
    {
        public UnidadeGasometro()
        {
            MedicaoItemGasometro = new HashSet<MedicaoItemGasometro>();
        }

        public int UnidadeId { get; set; }
        public int GasometroId { get; set; }
        public string GasometroMeasurer { get; set; }
        public string GasometroDevice { get; set; }
        public decimal? GasometroValorInicial { get; set; }
        public string GasometroStatus { get; set; }
        public short GasometroTipoMedicao { get; set; }

        public virtual Unidade Unidade { get; set; }
        public virtual ICollection<MedicaoItemGasometro> MedicaoItemGasometro { get; set; }
    }
}
