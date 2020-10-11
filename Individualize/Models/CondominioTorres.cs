using System;
using System.Collections.Generic;

namespace Individualize.Models
{
    public partial class CondominioTorres
    {
        public CondominioTorres()
        {
            Medicao = new HashSet<Medicao>();
            Unidade = new HashSet<Unidade>();
        }

        public short CondominioId { get; set; }
        public short CondominioTorresId { get; set; }
        public string CondominioTorresDsc { get; set; }
        public string CondominioTorresIdExport { get; set; }

        public virtual Condominio Condominio { get; set; }
        public virtual ICollection<Medicao> Medicao { get; set; }
        public virtual ICollection<Unidade> Unidade { get; set; }
    }
}
