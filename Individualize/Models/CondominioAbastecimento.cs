using System;
using System.Collections.Generic;

namespace Individualize.Models
{
    public partial class CondominioAbastecimento
    {
        public CondominioAbastecimento()
        {
            Medicao = new HashSet<Medicao>();
        }

        public short CondominioId { get; set; }
        public short CondominioAbastecimentoId { get; set; }
        public DateTime CondominioAbastecimentoData { get; set; }
        public decimal CondominioAbastecimentoQtd { get; set; }
        public decimal? FornecedorId { get; set; }

        public virtual Condominio Condominio { get; set; }
        public virtual Fornecedor Fornecedor { get; set; }
        public virtual ICollection<Medicao> Medicao { get; set; }
    }
}
