using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Individualize.Models
{
    public class Medicao
    {
        [Key]
        public int MedicaoId { get; set; }

        [Required(ErrorMessage ="Campo obrigatório.")]
        public DateTime MedicaoData { get; set; }
    }
}
    