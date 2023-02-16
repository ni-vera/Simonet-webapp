
using System.ComponentModel.DataAnnotations;

namespace webapp.Models
{
    public class Entrada
    {
        [Key]
        public String entrada { get; set; }
        [Required]
        public int pagina { get; set; }
    }
}
