using System;
using System.Collections.Generic;

namespace Identificación_Pais
{
    class Pais
    {
        public int PaisId { get; set; }

        public string Nombre { get; set; }

        public List<string> Provincia { get; set; }

        public List<Provincia> Provincias { get; set; }

        public int ObtenerNumeroDeHabitantes()
        {
            int acumulador = 0;
            foreach (Provincia actual in Provincias)
            {
                acumulador = acumulador + actual.ObtenerNumeroDeHabitantes();
            }
            return acumulador;
        }
    }



}

