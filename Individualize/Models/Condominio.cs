using System;
using System.ComponentModel.DataAnnotations;

namespace Individualize.Models
{
    public class Condominio
    {
        [Key]
        public int CondominioId { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MinLength(3,ErrorMessage ="Este campo deve conter no mínimo 3 caracters")]
        public string CondominioDsc { get;set; }
        public DateTime PrecoDataIni { get; set; }
        public DateTime PrecoDataFim { get; set; }
        public Boolean PrecoTaxaMinimaGas { get; set; }
        public Boolean PrecoTaxaMinimaAgua { get; set; }

        public int CondominioFornecedorGasId { get; set; }

        public Fornecedor Fornecedor { get; set; }
        
    }
}
