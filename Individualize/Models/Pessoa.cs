using System;
using System.Collections.Generic;

namespace Individualize.Models
{
    public partial class Pessoa
    {
        public Pessoa()
        {
            PessoaDependente = new HashSet<PessoaDependente>();
            QuestSocialPessoa = new HashSet<QuestSocialPessoa>();
        }

        public decimal PessoaId { get; set; }
        public string PessoaNome { get; set; }
        public string PessoaEnderecoRua { get; set; }
        public string PessoaEnderecoNum { get; set; }
        public int? PessoaEnderecoCep { get; set; }
        public decimal? PessoaFoneRes { get; set; }
        public decimal? PessoaFoneCel { get; set; }
        public int? BairroId { get; set; }
        public decimal? PessoaFoneCom { get; set; }
        public string PessoaEmail { get; set; }
        public string PessoaSexo { get; set; }
        public short? UltimoDependenteId { get; set; }
        public DateTime PessoaIncEm { get; set; }
        public short PessoaIncPor { get; set; }
        public DateTime? PessoaAltEm { get; set; }
        public short? PessoaAltPor { get; set; }

        public virtual Bairro Bairro { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual Fornecedor Fornecedor { get; set; }
        public virtual Funcionario Funcionario { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual ICollection<PessoaDependente> PessoaDependente { get; set; }
        public virtual ICollection<QuestSocialPessoa> QuestSocialPessoa { get; set; }
    }
}
