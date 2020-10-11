using System;
using System.Collections.Generic;

namespace Individualize.Models
{
    public partial class PerfilObjeto
    {
        public PerfilObjeto()
        {
            PerfilObjetoAcoes = new HashSet<PerfilObjetoAcoes>();
        }

        public short PerfilId { get; set; }
        public short ObjetoId { get; set; }
        public bool PerfilAcessoIns { get; set; }
        public bool PerfilAcessoUpd { get; set; }
        public bool PerfilAcessoDel { get; set; }
        public bool PerfilAcessoImp { get; set; }

        public virtual Objeto Objeto { get; set; }
        public virtual Perfil Perfil { get; set; }
        public virtual ICollection<PerfilObjetoAcoes> PerfilObjetoAcoes { get; set; }
    }
}
