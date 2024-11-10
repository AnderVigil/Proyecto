using System.ComponentModel.DataAnnotations;

namespace proyecto.Models
{
    public class Alquiler
    {
                  [Key]

        public int idAlquiler { get; set; }
        public int idCliente { get; set; }
        public int idPelicula { get; set; }
        public DateTime FechaAlquiler { get; set; }
        public DateTime? FechaDevolucion { get; set; } 
        public string Estado { get; set; } 
    }
}