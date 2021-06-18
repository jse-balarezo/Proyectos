using System;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido");
            Console.WriteLine("Ingrese la siguiente información");
            Console.WriteLine("Ingrese su Nombre:");
            var nombre = Console.ReadLine();

            Console.WriteLine("Ingrese su edad");
            string edad = Console.ReadLine();
            int edad1 = int.Parse(edad);

            //Console.WriteLine("Ingrese su Correo Electrónico");
            //var correo = Console.ReadLine();

            Console.WriteLine("Ingrese su Peso:");
            float peso = float.Parse(Console.ReadLine());
            var persona = new Persona();
            persona.nombre = nombre;
            persona.edad = edad1;
            persona.peso = peso;

            Console.WriteLine("Usted a ingresado lo siguiente");
            Console.WriteLine("Nombre: " + persona.nombre);
            Console.WriteLine("Edad: " + persona.edad);
            Console.WriteLine("Peso: " + persona.peso);
            Console.WriteLine("gracias por su infomación. Digite cualquier tecla para terminar");
            Console.ReadKey();

        }
        public void metodo(string[] args)
        { 


            if (args.Length > 0)
            {
                Console.WriteLine("Hola" + args[0]);
            }
            else
            {
                Console.WriteLine("Hola Desconocido");
            }
            Console.WriteLine("¿Cómo estás?");
            var estado = Console.ReadLine();
            Console.WriteLine("mmmmmm, entiendo");
            Console.ReadLine();
        }
    }
}

