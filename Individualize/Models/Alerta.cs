using System;
using System.Collections.Generic;

namespace Individualize.Models
{
    public partial class Alerta
    {
        public Alerta()
        {
            AgendamentoVistoria = new HashSet<AgendamentoVistoria>();
        }

        public short AlertaId { get; set; }
        public string AlertaTipo { get; set; }
        public DateTime AlertaDataOcorrencia { get; set; }
        public string AlertaSituacao { get; set; }
        public string AlertaObs { get; set; }
        public DateTime? AlertaDataResolucao { get; set; }
        public string AlertaProvidenciaTomada { get; set; }
        public decimal? FuncionarioId { get; set; }
        public short CondominioId { get; set; }

        public virtual Condominio Condominio { get; set; }
        public virtual Funcionario Funcionario { get; set; }
        public virtual ICollection<AgendamentoVistoria> AgendamentoVistoria { get; set; }
    }
}
