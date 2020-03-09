using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CrudNESS.Models
{
    [Table("tbUsuario")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName ="varchar(100)")]
        [Required]
        public string Nome { get; set; }
        [Column(TypeName ="varchar(11)")]
        [Required]
        public string Cpf { get; set; }
        [Column(TypeName ="varchar(11)")]
        public string Telefone { get; set; }
    }
}
