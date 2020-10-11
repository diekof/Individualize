using System;
using System.Collections.Generic;

namespace Individualize.Models
{
    public partial class MedicaoItem
    {
        public MedicaoItem()
        {
            MedicaoItemGasometro = new HashSet<MedicaoItemGasometro>();
            MedicaoItemHidrometro = new HashSet<MedicaoItemHidrometro>();
        }

        public int MedicaoId { get; set; }
        public int UnidadeId { get; set; }
        public string MedicaoItemObs { get; set; }
        public decimal MedicaoItemTotalAgua { get; set; }
        public decimal MedicaoItemTotalGas { get; set; }
        public string MedicaoItemMsgBoleto { get; set; }
        public string ContaStatus { get; set; }
        public DateTime ContaDataOcorrencia { get; set; }
        public decimal ContaPgtoPor { get; set; }
        public DateTime ContaPgtoEm { get; set; }
        public string MedicaoItemRetorno { get; set; }

        public virtual Usuario ContaPgtoPorNavigation { get; set; }
        public virtual Medicao Medicao { get; set; }
        public virtual Unidade Unidade { get; set; }
        public virtual ICollection<MedicaoItemGasometro> MedicaoItemGasometro { get; set; }
        public virtual ICollection<MedicaoItemHidrometro> MedicaoItemHidrometro { get; set; }
    }
}
