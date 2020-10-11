using System;
using System.Collections.Generic;

namespace Individualize.Models
{
    public partial class UnidadeHidrometro
    {
        public UnidadeHidrometro()
        {
            MedicaoItemHidrometro = new HashSet<MedicaoItemHidrometro>();
        }

        public int UnidadeId { get; set; }
        public int HidrometroId { get; set; }
        public string HidrometroMeasurer { get; set; }
        public string HidrometroDevice { get; set; }
        public decimal? HidrometroValorInicial { get; set; }
        public string HidrometroStatus { get; set; }
        public short HidrometroTipoMedicao { get; set; }

        public virtual Unidade Unidade { get; set; }
        public virtual ICollection<MedicaoItemHidrometro> MedicaoItemHidrometro { get; set; }
    }
}
