using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    class superCampeones
    {
        public string personajes;
        public string nombreSerie;
        public int numeroDeCapítulos;
        public string nombresEquipos;
        public string productora;
        public DateTime fechaDeCreación;
        public float velocidadOliver;
        public string nombreCreador;
        public int edadOliver;
        public DateTime fechaDeUltimoEpisodio;

        public void mostrarPersonajes()
        {
            Console.Write("Los personajes son: Oliver Atom, Benji Price, Richar Tex-Tex, Steve Hyuga \n");
        }
        public void mostrarNumeroDeCapítulos()
        {
            Console.Write("Los Supercampeones cuenta con 128 Capítulos \n");
        }
        public void mostrarNombresDeCapitulos()
        {
            Console.Write("Los equipos son: Newpi, Naughty Boys, York Town, Stampton FC \n");
        }
        public void mostrarProductora()
        {
            Console.Write("La productora de Super Campiones es: Madhouse \n");
        }
        public void mostrarfechaDeCreacion()
        {
            Console.Write("La fecha de la creación es: 27/03/1883 \n");
        }
    }
}
