using System;
using System.Collections.Generic;

namespace Individualize.Models
{
    public partial class Modulo
    {
        public Modulo()
        {
            Objeto = new HashSet<Objeto>();
            PerfilMenu = new HashSet<PerfilMenu>();
        }

        public short ModuloId { get; set; }
        public string ModuloDsc { get; set; }
        public byte[] ModuloImg { get; set; }
        public string ModuloImgTipo { get; set; }
        public string ModuloImgNome { get; set; }

        public virtual ICollection<Objeto> Objeto { get; set; }
        public virtual ICollection<PerfilMenu> PerfilMenu { get; set; }
    }
}
