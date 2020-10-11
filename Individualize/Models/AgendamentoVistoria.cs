using System;
using System.Collections.Generic;

namespace Individualize.Models
{
    public partial class AgendamentoVistoria
    {
        public AgendamentoVistoria()
        {
            AgendamentoVistoriaTram = new HashSet<AgendamentoVistoriaTram>();
        }

        public int AgendamentoVistCod { get; set; }
        public DateTime AgendamentoVistData { get; set; }
        public string AgendamentoVistObs { get; set; }
        public short AgendamentoVistContato { get; set; }
        public DateTime? AgendamentoVistDataResp { get; set; }
        public string AgendamentoVistResposta { get; set; }
        public int UnidadeId { get; set; }
        public string AgendamentoVistContatoTexto { get; set; }
        public string AgendamentoVistProtocolo { get; set; }
        public string AgendamentoVistTitulo { get; set; }
        public short? AlertaId { get; set; }
        public short AgendamentoVistSituacao { get; set; }

        public virtual Alerta Alerta { get; set; }
        public virtual Unidade Unidade { get; set; }
        public virtual ICollection<AgendamentoVistoriaTram> AgendamentoVistoriaTram { get; set; }
    }
}
