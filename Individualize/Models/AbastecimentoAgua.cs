using System;
using System.Collections.Generic;

namespace Individualize.Models
{
    public partial class AbastecimentoAgua
    {
        public short CondominioId { get; set; }
        public short AbastecimentoAguaId { get; set; }
        public DateTime AbastecimentoAguaData { get; set; }
        public decimal AbastecimentoAguaQtd { get; set; }
        public decimal AbastecimentoAguaValor { get; set; }
        public decimal FornecedorId { get; set; }

        public virtual Condominio Condominio { get; set; }
        public virtual Fornecedor Fornecedor { get; set; }
    }
}
