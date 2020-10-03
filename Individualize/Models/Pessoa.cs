using System;
using System.ComponentModel.DataAnnotations;

namespace Individualize.Models
{
    public class Pessoa
    {
        [Key]
        public int PessoaId { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório.")]
        [MinLength(3, ErrorMessage = "Este campo deve conter no mínimo 3 caracters.")]
        [MaxLength(100,ErrorMessage ="Este campo deve conter no máximo 100 caracteres.")]
        public String PessoaNome { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório.")]
        [MinLength(3, ErrorMessage = "Este campo deve conter no mínimo 3 caracters.")]
        [MaxLength(100, ErrorMessage = "Este campo deve conter no máximo 100 caracteres.")]
        public String PessoaEnderecoRua { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório.")]
        [MinLength(3, ErrorMessage = "Este campo deve conter no mínimo 3 caracters.")]
        [MaxLength(100, ErrorMessage = "Este campo deve conter no máximo 100 caracteres.")]
        public String PessoaEnderecoNum { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório.")]
        [MinLength(3, ErrorMessage = "Este campo deve conter no mínimo 3 caracters.")]
        [MaxLength(100, ErrorMessage = "Este campo deve conter no máximo 100 caracteres.")]
        public String PessoaEnderecoCep { get; set; }
        public decimal PessoaFoneRes { get; set; }
        public decimal PessoaFoneCel { get; set; }
        public decimal PessoaFoneCom { get; set; }
        public String PessoaEmail { get; set; }
        public char PessoaSexo { get; set; }

    }
}
