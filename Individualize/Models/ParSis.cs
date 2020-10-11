using System;
using System.Collections.Generic;

namespace Individualize.Models
{
    public partial class ParSis
    {
        public short ParSisId { get; set; }
        public DateTime ParSisDataIni { get; set; }
        public DateTime? ParSisDataFim { get; set; }
        public decimal ParSisConsumoInsignificanteAgu { get; set; }
        public decimal ParSisConsumoInsignificanteGas { get; set; }
        public decimal ParSisConsumoExageradoAgua { get; set; }
        public decimal ParSisConsumoExageradoGas { get; set; }
        public string ParSisBoletoFraseGeral { get; set; }
        public short ParSisBoletoQtdHistoricoGrafic { get; set; }
        public short ParSisBoletoQtdDiasVencimento { get; set; }
        public short ParSisUsuarioDefSenhaSize { get; set; }
        public short ParSisUsuarioDefSenhaTipoStr { get; set; }
        public short ParSisUsuarioDefSenhaTipoCap { get; set; }
        public string ParSisUsuarioTermoUtilizacao { get; set; }
        public decimal? ParSisEmpFone { get; set; }
        public string ParSisEmpEnd1 { get; set; }
        public string ParSisEmpEnd2 { get; set; }
        public string ParSisEmpEnd3 { get; set; }
        public string ParSisEmpEmail { get; set; }
        public string ParSisEmpSite { get; set; }
        public string ParSisEmpNome { get; set; }
        public string ParSisEmpCnpj { get; set; }
    }
}
