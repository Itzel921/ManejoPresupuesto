using System.ComponentModel.DataAnnotations;

namespace ManejoPresupuesto.Models
{
    public class TipoCuenta
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")] //Tag helper para validar que el campo no este vacio
        public string Nombre { get; set; }
        public int UsuarioId { get; set; }
        public int Orden { get; set; }

    }
}
