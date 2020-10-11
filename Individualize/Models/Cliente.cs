using System;
using System.Collections.Generic;

namespace Individualize.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            Unidade = new HashSet<Unidade>();
        }

        public decimal ClienteId { get; set; }
        public string ClienteCpf { get; set; }
        public DateTime ClienteIncEm { get; set; }
        public short ClienteIncPor { get; set; }
        public DateTime? ClienteAltEm { get; set; }
        public short? ClienteAltPor { get; set; }

        public virtual Pessoa ClienteNavigation { get; set; }
        public virtual ICollection<Unidade> Unidade { get; set; }
    }
}
