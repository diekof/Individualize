using System;
using System.Collections.Generic;

namespace Individualize.Models
{
    public partial class PerfilMenu
    {
        public short PerfilId { get; set; }
        public short ModuloId { get; set; }
        public string PerfilMenu1 { get; set; }

        public virtual Modulo Modulo { get; set; }
        public virtual Perfil Perfil { get; set; }
    }
}
