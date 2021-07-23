using System.ComponentModel.DataAnnotations.Schema;

namespace JonathanBalarezoExamenWeb.Entities
{
    public class Conyuge
    {
        public int ConyugeId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        [ForeignKey("Empleado")]
        public int EmpleadoId { get; set; }
        public Empleado Empleado{ get; set; }
    }
}
