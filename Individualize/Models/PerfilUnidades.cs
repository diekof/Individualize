using System;
using System.Collections.Generic;

namespace Individualize.Models
{
    public partial class PerfilUnidades
    {
        public short PerfilId { get; set; }
        public int UnidadeId { get; set; }

        public virtual Perfil Perfil { get; set; }
        public virtual Unidade Unidade { get; set; }
    }
}
