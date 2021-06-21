using System;

namespace Tarea1
{
    class Program
    {

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Elige una opción\n" +
                "\n1.- Doraemon" +
                "\n2.- Thundercats" +
                "\n3.- Super Campeones" +
                "\n4.- Tortugas Ninja" +
                "\n5.- Free Fire" +
                "\n6.- Salir");

                int i1 = 0;
                i1 = Convert.ToInt16(Console.ReadLine());

                switch (i1)
                {
                    case 1:
                        var cosmico = new Doraemon();
                        cosmico.mostrarPersonaje();
                        cosmico.mostrarNombreSerie();
                        cosmico.mostrarCapitulos();
                        cosmico.mostrarFechaUltimoCapitulo();
                        cosmico.mostrarArtefactos();
                        break;

                    case 2:
                        var thunder = new Thundercats();
                        thunder.mostrarPersonaje();
                        thunder.mostrarNombreSerie();
                        thunder.mostrarCapitulos();
                        thunder.mostrarEnemigos();
                        thunder.mostrarEquipaciones();
                        break;

                    case 3:
                        var campeones = new superCampeones();
                        campeones.mostrarPersonajes();
                        campeones.mostrarNumeroDeCapítulos();
                        campeones.mostrarNombresDeCapitulos();
                        campeones.mostrarProductora();
                        campeones.mostrarfechaDeCreacion();
                        break;

                    case 4:
                        var tortuga = new TortugasNinja();
                        tortuga.mostrarPersonaje();
                        tortuga.mostrarNombreSerie();
                        tortuga.mostrarCapitulos();
                        tortuga.mostrarEnemigos();
                        tortuga.mostrarNombreDeProductora();
                        break;

                    case 5:
                        var free = new FreeFire();
                        free.mostrarPersonaje();
                        free.mostrarNombreDeVideoJuego();
                        free.mostrarNombreDeCreador();
                        free.mostrarNumeroDeActualizaciones();
                        free.mostrarLugaresDeMapa();
                        break;
                                                
                    default:
                        Console.WriteLine("No ha seleccionado una opción correcta");
                        break;
                }
                if (i1 == 6)
                {
                    Console.WriteLine("Gracias por utilizar nuestro Programa");
                    break;
                }

            }
        }
    }

}



