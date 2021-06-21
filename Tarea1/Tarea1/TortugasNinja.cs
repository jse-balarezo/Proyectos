using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    class TortugasNinja
    {
        public string personajes;
        public string nombreSerie;
        public int numeroDeCapítulos;
        public string Enemigos;
        public string nombreDeProductora;
        public DateTime fechaDeCreación;
        public float pesoEstaturaDeTortuga;
        public string nombreCreador;
        public int edadTortugas;
        public string comidaFavorita;

        public void mostrarPersonaje()
        {
            Console.Write("Los personajes son: Donatelo, Leonardo, Rafael, Splinter, Miguel \n");
        }
        public void mostrarNombreSerie()
        {
            Console.Write("El nombre de la Serie se llama Las Tortugas Ninja \n");
        }
        public void mostrarCapitulos()
        {
            Console.Write("La Serie Tuvo 193 Capítulos \n");
        }
        public void mostrarEnemigos()
        {
            Console.Write("Los enemigos de las Totugas Nija son: Sheredder, krang, Bebop, Syockman \n");
        }
        public void mostrarNombreDeProductora()
        {
            Console.Write("La Productora de las Tortugas Ninja es Paramount Pictures \n");
        }
    }
}
