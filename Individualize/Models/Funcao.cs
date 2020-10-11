using System;
using System.Collections.Generic;

namespace Individualize.Models
{
    public partial class Funcao
    {
        public Funcao()
        {
            Funcionario = new HashSet<Funcionario>();
        }

        public short FuncaoId { get; set; }
        public string FuncaoDsc { get; set; }

        public virtual ICollection<Funcionario> Funcionario { get; set; }
    }
}
