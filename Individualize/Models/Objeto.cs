using System;
using System.Collections.Generic;

namespace Individualize.Models
{
    public partial class Objeto
    {
        public Objeto()
        {
            InverseObjetoPai = new HashSet<Objeto>();
            ObjetoAcao = new HashSet<ObjetoAcao>();
            PerfilObjeto = new HashSet<PerfilObjeto>();
        }

        public short ObjetoId { get; set; }
        public string ObjetoNome { get; set; }
        public string ObjetoDsc { get; set; }
        public short? ObjetoPaiId { get; set; }
        public short? ModuloId { get; set; }
        public bool? ObjetoMenuLink { get; set; }

        public virtual Modulo Modulo { get; set; }
        public virtual Objeto ObjetoPai { get; set; }
        public virtual ICollection<Objeto> InverseObjetoPai { get; set; }
        public virtual ICollection<ObjetoAcao> ObjetoAcao { get; set; }
        public virtual ICollection<PerfilObjeto> PerfilObjeto { get; set; }
    }
}
