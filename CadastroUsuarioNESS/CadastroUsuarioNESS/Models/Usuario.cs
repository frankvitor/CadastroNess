using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroUsuarioNESS.Models
{
    [Table("tbUsuario")]
    public class Usuario
    {
        [Key] 
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Cpf { get; set; }
        public string Telefone { get; set; }
    }
}
