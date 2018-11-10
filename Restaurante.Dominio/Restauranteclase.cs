using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.Dominio
{
    [Table("Restauranteclase")]
    public class Restauranteclase
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string NombreR { get; set; }

        [Required]
        [MaxLength(50)]
        public string DireccionR { get; set; }

        [Required]
        [MaxLength(50)]
        public string TelefonoR { get; set; }

        [Required]
        [MaxLength(50)]
        public string HoratioR { get; set; }

        public string Imagen { get; set; }
    }
}
