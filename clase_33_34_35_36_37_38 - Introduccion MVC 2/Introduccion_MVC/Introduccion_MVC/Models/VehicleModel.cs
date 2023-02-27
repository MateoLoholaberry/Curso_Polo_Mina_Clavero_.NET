using System.ComponentModel.DataAnnotations;

namespace Introduccion_MVC.Models
{
    public class VehicleModel
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "El campo Dominio es obligatorio")]
        [StringLength(7, ErrorMessage = "El Dominio debe contener al 6 0 7 caracteres", MinimumLength = 6)]
        public string Dominio { get; set; }
        
        [Required(ErrorMessage = "El campo Numero de chasis es obligatorio")]
        public string NumeroChasis { get; set; }
        
        [Required(ErrorMessage = "El campo Propietario es obligatorio")]
        public string Propietario { get; set; }
       
        [Required(ErrorMessage = "El campo Año de fabricación es obligatorio")]
        public int AnioFabricacion { get; set; }
    }
}
