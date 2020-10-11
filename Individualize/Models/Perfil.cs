using System;
using System.Collections.Generic;

namespace Individualize.Models
{
    public partial class Perfil
    {
        public Perfil()
        {
            PerfilMenu = new HashSet<PerfilMenu>();
            PerfilObjeto = new HashSet<PerfilObjeto>();
            PerfilUnidades = new HashSet<PerfilUnidades>();
            Usuario = new HashSet<Usuario>();
        }

        public short PerfilId { get; set; }
        public string PerfilDsc { get; set; }
        public string PerfilTipoUnidades { get; set; }

        public virtual ICollection<PerfilMenu> PerfilMenu { get; set; }
        public virtual ICollection<PerfilObjeto> PerfilObjeto { get; set; }
        public virtual ICollection<PerfilUnidades> PerfilUnidades { get; set; }
        public virtual ICollection<Usuario> Usuario { get; set; }
    }
}
