using System;
using System.Collections.Generic;

namespace Individualize.Models
{
    public partial class AgendamentoVistoriaTram
    {
        public int AgendamentoVistTramCod { get; set; }
        public int AgendamentoVistCod { get; set; }
        public DateTime AgendamentoVistTramData { get; set; }
        public string AgendamentoVistTramUsuario { get; set; }
        public string AgendamentoVistTramAcao { get; set; }
        public string AgendamentoVistTramTexto { get; set; }

        public virtual AgendamentoVistoria AgendamentoVistCodNavigation { get; set; }
    }
}
