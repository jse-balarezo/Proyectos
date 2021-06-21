using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    class FreeFire
    {
        public string personajes;
        public string nombreVideoJuego;
        public string nombreDeCreador;
        public int numeroDeActualizaciones;
        public string lugaresDelMapa;
        public string armas;
        public DateTime fechaDeLanzamiento;
        public float pesoDelJuego;
        public string nombreDeMapas;
        public int numeroDeVida;
        
        public void mostrarPersonaje()
        {
            Console.Write("Los personajes son: Cla, Alok, Adrew, Caroline, Ayato, Kelly, Ford, Alvaro, Antonio \n");
        }
        public void mostrarNombreDeVideoJuego()
        {
            Console.Write("El Video Juego Se Llama: Free Fire \n");
        }
        public void mostrarNombreDeCreador()
        {
            Console.Write("El creador de Free Fire es: 111Dots Studio \n");
        }
        public void mostrarNumeroDeActualizaciones()
        {
            Console.Write("Los personajes son \n");
        }
        public void mostrarLugaresDeMapa()
        {
            Console.Write("Los lugares del mapa son: Pochinock, Mill, Bilmasaki, Clock Tower, Peak, Factory \n");
        }
    }
}
