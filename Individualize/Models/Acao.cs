using System;
using System.Collections.Generic;

namespace Individualize.Models
{
    public partial class Acao
    {
        public Acao()
        {
            ObjetoAcao = new HashSet<ObjetoAcao>();
        }

        public short AcaoId { get; set; }
        public string AcaoDsc { get; set; }

        public virtual ICollection<ObjetoAcao> ObjetoAcao { get; set; }
    }
}
