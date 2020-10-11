using System;
using System.Collections.Generic;

namespace Individualize.Models
{
    public partial class PessoaDependente
    {
        public decimal PessoaId { get; set; }
        public short DependenteId { get; set; }
        public string DependenteSexo { get; set; }
        public short? DependenteIdade { get; set; }

        public virtual Pessoa Pessoa { get; set; }
    }
}
