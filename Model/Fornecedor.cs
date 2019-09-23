using System;
using System.ComponentModel.DataAnnotations;

namespace MinhaApiCore.Model
{
    public class Fornecedor
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} e obrigatorio")]
        [StringLength(100, ErrorMessage= "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} e obrigatorio")]
        [StringLength(100, ErrorMessage= "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 14)]
        public string Documento { get; set; }

        public int TipoFornecedor { get; set; }

        public bool Ativo { get; set; }
        
    }
}