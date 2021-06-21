using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    class Thundercats
    {
        public string personajes;
        public string nombreSerie;
        public int capítulos;
        public string enemigos;
        public string equipaciones;
        public DateTime fechaUltimoCapitulo;
        public float pesoTemporada;
        public string nombreDeEspada;
        public int nombrePlanetas;
        public int numerosVehículos;

        public void mostrarPersonaje()
        {
            Console.Write("Los personajes son: Lion-O, Cheetara, Pantro, Felina, Felino, Snarf, Tigro \n");
        }
        public void mostrarNombreSerie()
        {
            Console.Write("El Nombre es: Thundercats \n");
        }
        public void mostrarCapitulos()
        {
            Console.Write("Los Thundercats cuentan con 130 Episodios \n");
        }
        public void mostrarEnemigos()
        {
            Console.Write("Mumm-ra, Mandrilo, Grune, Barrenador \n");
        }
        public void mostrarEquipaciones()
        {
            Console.Write("La equipación de los Thundercats es: Espada del Agurio, Chacos, Mente, Velocidad \n");
        }
    }
}
