using System;
using System.Collections.Generic;

namespace Individualize.Models
{
    public partial class Patrimonio
    {
        public short PatrimonioId { get; set; }
        public short PatrimonioNum { get; set; }
        public string PatrimonioDsc { get; set; }
        public DateTime PatrimonioDataAquisicao { get; set; }
        public string PatrimonioEstadoConservacao { get; set; }
        public short PatrimonioQtd { get; set; }
        public string PatrimonioUnidadeMedida { get; set; }
        public decimal PatrimonioValorUnitario { get; set; }
    }
}
