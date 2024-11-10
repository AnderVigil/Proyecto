using System.ComponentModel.DataAnnotations;

namespace proyecto.Models
{
    public class Pelicula
    {
        [Key]

        public int idPelicula { get; set; }
        public string Nombre { get; set; }
        public string Autor { get; set; }
        public string Sinopsis { get; set; }
        public string Duracion { get; set; }
        public string Clasificacion { get; set; }

    }
}
