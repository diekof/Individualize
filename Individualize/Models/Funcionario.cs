using System;
using System.Collections.Generic;

namespace Individualize.Models
{
    public partial class Funcionario
    {
        public Funcionario()
        {
            Alerta = new HashSet<Alerta>();
            Medicao = new HashSet<Medicao>();
        }

        public decimal FuncionarioId { get; set; }
        public short FuncaoId { get; set; }

        public virtual Funcao Funcao { get; set; }
        public virtual Pessoa FuncionarioNavigation { get; set; }
        public virtual ICollection<Alerta> Alerta { get; set; }
        public virtual ICollection<Medicao> Medicao { get; set; }
    }
}
