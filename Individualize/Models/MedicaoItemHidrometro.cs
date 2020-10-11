using System;
using System.Collections.Generic;

namespace Individualize.Models
{
    public partial class MedicaoItemHidrometro
    {
        public int MedicaoId { get; set; }
        public int UnidadeId { get; set; }
        public int HidrometroId { get; set; }
        public decimal MedicaoItemAguaHidrometro { get; set; }

        public virtual MedicaoItem MedicaoItem { get; set; }
        public virtual UnidadeHidrometro UnidadeHidrometro { get; set; }
    }
}
