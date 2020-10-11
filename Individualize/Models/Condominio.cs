using System;
using System.Collections.Generic;

namespace Individualize.Models
{
    public partial class Condominio
    {
        public Condominio()
        {
            AbastecimentoAgua = new HashSet<AbastecimentoAgua>();
            Alerta = new HashSet<Alerta>();
            CondominioAbastecimento = new HashSet<CondominioAbastecimento>();
            CondominioPrecoAgua = new HashSet<CondominioPrecoAgua>();
            CondominioPrecoGas = new HashSet<CondominioPrecoGas>();
            CondominioTorres = new HashSet<CondominioTorres>();
            Notificacao = new HashSet<Notificacao>();
            QuestSocialCondominio = new HashSet<QuestSocialCondominio>();
        }

        public short CondominioId { get; set; }
        public string CondominioDsc { get; set; }
        public short CondominioUltimaTorreId { get; set; }
        public int CondominioBairroId { get; set; }
        public short PrecoUltimoGasId { get; set; }
        public short PrecoUltimoAguaId { get; set; }
        public bool PrecoTaxaMinimaGas { get; set; }
        public bool PrecoTaxaMinimaAgua { get; set; }
        public DateTime PrecoDataFim { get; set; }
        public DateTime PrecoDataIni { get; set; }
        public decimal CondominioFornecedorGasId { get; set; }
        public decimal CondominioFornecedorAguaId { get; set; }
        public short CondominioUltimaAbstId { get; set; }
        public decimal? CondominioAreaComumAgua { get; set; }
        public decimal? CondominioAreaComumGas { get; set; }
        public short CondominioTaxaEsgoto { get; set; }
        public string CondominioAreaComumAguaTipo { get; set; }
        public string CondominioAreaComumGasTipo { get; set; }
        public string CondominioBolMensagemRodape { get; set; }
        public string CondominioBolMensagemAgua { get; set; }
        public string CondominioIdExport { get; set; }
        public short CondominioUltimaAbstAguaId { get; set; }

        public virtual Bairro CondominioBairro { get; set; }
        public virtual Fornecedor CondominioFornecedorAgua { get; set; }
        public virtual Fornecedor CondominioFornecedorGas { get; set; }
        public virtual ICollection<AbastecimentoAgua> AbastecimentoAgua { get; set; }
        public virtual ICollection<Alerta> Alerta { get; set; }
        public virtual ICollection<CondominioAbastecimento> CondominioAbastecimento { get; set; }
        public virtual ICollection<CondominioPrecoAgua> CondominioPrecoAgua { get; set; }
        public virtual ICollection<CondominioPrecoGas> CondominioPrecoGas { get; set; }
        public virtual ICollection<CondominioTorres> CondominioTorres { get; set; }
        public virtual ICollection<Notificacao> Notificacao { get; set; }
        public virtual ICollection<QuestSocialCondominio> QuestSocialCondominio { get; set; }
    }
}
