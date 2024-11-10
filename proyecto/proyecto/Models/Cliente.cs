using System.ComponentModel.DataAnnotations;

namespace proyecto.Models
{
    public class Cliente
    {
        [Key]

        public int idCliente { get; set; }
        public string Nombre { get; set; }
        public string Dui { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

    }
}
