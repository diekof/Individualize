using System;
using System.Collections.Generic;

namespace Individualize.Models
{
    public partial class ObjetoAcao
    {
        public ObjetoAcao()
        {
            PerfilObjetoAcoes = new HashSet<PerfilObjetoAcoes>();
        }

        public short ObjetoId { get; set; }
        public short AcaoId { get; set; }

        public virtual Acao Acao { get; set; }
        public virtual Objeto Objeto { get; set; }
        public virtual ICollection<PerfilObjetoAcoes> PerfilObjetoAcoes { get; set; }
    }
}
