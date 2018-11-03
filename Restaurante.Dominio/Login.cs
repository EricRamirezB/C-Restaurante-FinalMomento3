using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Restaurante.Dominio
{
    [Table("Login")]
    public class Login
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Usuario { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
