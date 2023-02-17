using System.ComponentModel.DataAnnotations;

namespace webapp.Models
{
    public class Propuesta
    {
        [Key]
        public String entrada { get; set; }
        [Required]
        public int pagina { get; set; }
        public String Colaborador { get; set; }
        public String Correo { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Today;
        public String Estado { get; set; } = "Pendiente";
    }
}
