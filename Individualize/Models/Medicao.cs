using System;
using System.ComponentModel.DataAnnotations;

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
    