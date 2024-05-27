using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;

namespace T2_Enciso_Renato.Models
{
    public class Distribuidor
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "El Nombre del distribuidor es obligatorio")]
        public string NombreDistribuidor { get; set; }
        [Required(ErrorMessage = "La Razon Social es obligatoria")]
        public string RazonSocial { get; set; }
        [Required(ErrorMessage = "El número de Telefono es obligatorio")]
        public string Telefono { get; set; }
        [Required(ErrorMessage = "El Año Inicio de Operación es obligatorio")]
        [Range(1900, 3000, ErrorMessage = "El Año Inicio de Operación es entre 1900 a 3000")]
        public int AnioInicioOperacion { get; set; }
        [Required(ErrorMessage = "El contacto es obligatorio")]
        public string Contacto { get; set; }



    }
}
