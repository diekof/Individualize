using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic;

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
    }
}
