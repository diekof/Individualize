using System;
using System.Collections.Generic;

namespace Individualize.Models
{
    public partial class LogAcesso
    {
        public short LogAcessoId { get; set; }
        public decimal UsuarioId { get; set; }
        public DateTime LogAcessoData { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
