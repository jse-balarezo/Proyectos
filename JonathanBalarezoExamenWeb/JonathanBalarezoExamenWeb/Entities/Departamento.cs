using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JonathanBalarezoExamenWeb.Entities
{
    public class Departamento
    {
        public int DepartamentoId { get; set; }
        public string Nombre { get; set; }
        //public Empleado Director { get; set; }
        public List<Empleado> Empleados { get; set; }
    }
     
}
