using System;
using System.Collections.Generic;

namespace Individualize.Models
{
    public partial class Bairro
    {
        public Bairro()
        {
            Condominio = new HashSet<Condominio>();
            Pessoa = new HashSet<Pessoa>();
        }

        public int BairroId { get; set; }
        public string BairroDsc { get; set; }
        public int CidadeId { get; set; }

        public virtual Cidade Cidade { get; set; }
        public virtual ICollection<Condominio> Condominio { get; set; }
        public virtual ICollection<Pessoa> Pessoa { get; set; }
    }
}
