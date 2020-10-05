using System.ComponentModel.DataAnnotations;

namespace Individualize.Models
{
    public class Fornecedor
    {
        public int FornecedorId { get; set; }
        public Pessoa Pessoa { get; set; }
        [Required(ErrorMessage = "Este campo é obrigatório.")]
        public string FornecedorCNPJ { get; set; }
        public string FornecedorTipo { get; set; }
    }
}
