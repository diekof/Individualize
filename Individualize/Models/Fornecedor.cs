using System;
using System.Collections.Generic;

namespace Individualize.Models
{
    public partial class Fornecedor
    {
        public Fornecedor()
        {
            AbastecimentoAgua = new HashSet<AbastecimentoAgua>();
            CondominioAbastecimento = new HashSet<CondominioAbastecimento>();
            CondominioCondominioFornecedorAgua = new HashSet<Condominio>();
            CondominioCondominioFornecedorGas = new HashSet<Condominio>();
        }

        public decimal FornecedorId { get; set; }
        public string FornecedorCnpj { get; set; }
        public string FornecedorTipo { get; set; }

        public virtual Pessoa FornecedorNavigation { get; set; }
        public virtual ICollection<AbastecimentoAgua> AbastecimentoAgua { get; set; }
        public virtual ICollection<CondominioAbastecimento> CondominioAbastecimento { get; set; }
        public virtual ICollection<Condominio> CondominioCondominioFornecedorAgua { get; set; }
        public virtual ICollection<Condominio> CondominioCondominioFornecedorGas { get; set; }
    }
}
