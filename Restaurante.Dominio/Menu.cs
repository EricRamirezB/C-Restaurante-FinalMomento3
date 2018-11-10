using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.Dominio
{
    [Table("Menu")]
    public class Menu
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string NombreM { get; set; }

        [Required]
        [MaxLength(50)]
        public string DescripcionM { get; set; }

        [Required]
        [MaxLength(50)]
        public string FechaPedidoM { get; set; }

        [Required]
        public int precio { get; set; }

        public string ImagenM { get; set; }
    }
}
