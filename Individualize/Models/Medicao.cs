using System;
using System.Collections.Generic;

namespace Individualize.Models
{
    public partial class Medicao
    {
        public Medicao()
        {
            MedicaoItem = new HashSet<MedicaoItem>();
            MedicaoPrecoAgua = new HashSet<MedicaoPrecoAgua>();
            MedicaoPrecoGas = new HashSet<MedicaoPrecoGas>();
        }

        public int MedicaoId { get; set; }
        public DateTime MedicaoData { get; set; }
        public short CondominioId { get; set; }
        public short CondominioTorresId { get; set; }
        public decimal FuncionarioId { get; set; }
        public string MedicaoStatus { get; set; }
        public bool MedicaoPrecoTaxaMinimaAgua { get; set; }
        public bool MedicaoPrecoTaxaMinimaGas { get; set; }
        public decimal MedicaoRegistroGeralAgua { get; set; }
        public decimal MedicaoAreaComumGas { get; set; }
        public decimal MedicaoTotalAreaComumAgua { get; set; }
        public decimal MedicaoTotalAreaComumGas { get; set; }
        public decimal MedicaoCondominioAreaComumAgua { get; set; }
        public decimal MedicaoCondominioAreaComumGas { get; set; }
        public short MedicaoTaxaEsgotoPerc { get; set; }
        public DateTime MedicaoVencimento { get; set; }
        public string MedicaoDensidadeTipo { get; set; }
        public decimal MedicaoDensidadeInformada { get; set; }
        public short? CondominioAbastecimentoId { get; set; }
        public bool MedicaoPrecoAguaTaxaMinima { get; set; }
        public bool MedicaoPrecoGasTaxaMinima { get; set; }

        public virtual CondominioAbastecimento Condominio { get; set; }
        public virtual CondominioTorres CondominioNavigation { get; set; }
        public virtual Funcionario Funcionario { get; set; }
        public virtual ICollection<MedicaoItem> MedicaoItem { get; set; }
        public virtual ICollection<MedicaoPrecoAgua> MedicaoPrecoAgua { get; set; }
        public virtual ICollection<MedicaoPrecoGas> MedicaoPrecoGas { get; set; }
    }
}
