using System;
using System.Collections.Generic;

namespace Individualize.Models
{
    public partial class Notificacao
    {
        public short NotificacaoId { get; set; }
        public string NotificacaoAssunto { get; set; }
        public DateTime NotificacaoDataElaboracao { get; set; }
        public DateTime? NotificacaoDataProtocolo { get; set; }
        public string NotificacaoCorpo { get; set; }
        public short CondominioId { get; set; }

        public virtual Condominio Condominio { get; set; }
    }
}
