using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    class Doraemon
    {
        public string personajes;
        public string nombreSerie;
        public int capítulos;
        public string Enemigos;
        public string artefactos;
        public DateTime fechaUltimoCapitulo;
        public float pesoTemporada;
        public string nombreEscuela;
        public int numeroJuguetesSueneo;
        public int numerosCasas;
    
        public void mostrarPersonaje() 
        {
            Console.Write("Los personajes son: Doraemon, Nobita, Shizuka, Gigante, Suneo \n");
        }
        public void mostrarNombreSerie()
        {
            Console.Write("El nombre de la serie es: Doraemon el Gato Cosmico \n");
        }
        public void mostrarCapitulos()
        {
            Console.Write("En la actualidad hay 46 Volumenes \n");
        }
        public void mostrarFechaUltimoCapitulo()
        {
            Console.Write("La Fecha del Ultimo capítulo fue: 19 de Junio del 2019 \n");
        }
        public void mostrarArtefactos()
        {
            Console.Write("Los artefactos son: Gorrocóptero, Máquina del Tiempo, Huevo de impronta, Puerta Mágica \n");
        }
    }
}
