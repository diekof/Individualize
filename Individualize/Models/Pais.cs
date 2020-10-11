using System;
using System.Collections.Generic;

namespace Individualize.Models
{
    public partial class Pais
    {
        public Pais()
        {
            Estado = new HashSet<Estado>();
        }

        public short PaisId { get; set; }
        public string PaisDsc { get; set; }

        public virtual ICollection<Estado> Estado { get; set; }
    }
}
