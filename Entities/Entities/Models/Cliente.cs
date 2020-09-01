using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(150, ErrorMessage = "O nome deve ter até no máximo 150 caracteres")]
        public string Nome { get; set; }

        [Required]
        [MaxLength(10, ErrorMessage = "CPF deve conter no máximo 10 caracteres")]
        public string CPF { get; set; }
        [Required]
        public DateTime DataNascimento { get; set; }
        public DateTime DataCadastro => DateTime.Now;
        [MinLength(0, ErrorMessage = "A renda deve ser no mínimo igual a 0")]
        public decimal Renda { get; set; }
    }
}
