using System;
using System.Collections.Generic;

namespace Individualize.Models
{
    public partial class PerfilObjetoAcoes
    {
        public short PerfilId { get; set; }
        public short ObjetoId { get; set; }
        public short AcaoId { get; set; }
        public bool PerfilAcessoAcao { get; set; }

        public virtual ObjetoAcao ObjetoAcao { get; set; }
        public virtual PerfilObjeto PerfilObjeto { get; set; }
    }
}
