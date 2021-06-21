using System;

namespace primerPrograma
{
    class Programa
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenidos");
            Console.WriteLine("Ingrese la iformación solicitada");

            Console.WriteLine("Ingrese su nombre");
            string nombre = Console.ReadLine();

            int edad = IngresarEdad();

            Console.WriteLine("Ingrese su fecha de nacimiento");
            string fechaCumpleaños = Console.ReadLine();
            DateTime fechaCumpleaños1 = DateTime.Parse(fechaCumpleaños);

            float estatura = IngresarEstatura();

            Console.WriteLine("Es mayor de Edad");
            bool esMayorEdad = Console.ReadLine().ToUpper() == "SI";

            Console.WriteLine("Ingrese su nota parcial");
            string notaParcial = Console.ReadLine();
            double notaParcial1 = double.Parse(notaParcial);

            Console.WriteLine("Ingrese su color de preferencia");
            string colorFavorito = Console.ReadLine();

            Console.WriteLine("Ingrese su cedula");
            string cedula = Console.ReadLine();

            Console.WriteLine("Ingrese su numero de calzado");
            string tallaZapato = Console.ReadLine();
            float tallaZapato1 = float.Parse(tallaZapato);

            Console.WriteLine("Ingrese su animal favorito");
            string animalFavorito = Console.ReadLine();

            var persona = new Persona
            {
                nombre = nombre,
                edad = edad,
                fechaCumpleaños = fechaCumpleaños1,
                estatura = estatura,
                esMayorEdad = esMayorEdad,
                notaParcial = notaParcial1,
                colorFavorito = colorFavorito,
                cedula = cedula,
                tallaZapato = tallaZapato1,
                animalFavorito = animalFavorito
            };

            Console.WriteLine("Usted ingresó la siguiente información:");
            Console.Write($"Nombre: {persona.nombre} ");
            Console.Write($"Edad: {persona.edad} ");
            Console.Write($"Cumpleaños es: {persona.fechaCumpleaños} ");
            Console.Write($"Estatura {persona.estatura} ");
            Console.Write($"Mayoria de Edad: {persona.esMayorEdad} ");
            Console.Write($"su nota parcial es: {persona.notaParcial} ");
            Console.Write($"Su color Favorito es: {persona.colorFavorito} ");
            Console.Write($"Su numero de Cedula es: {persona.cedula} ");
            Console.Write($"Su Talla de Zapato es: {persona.tallaZapato} ");
            Console.Write($"Su animal Favorito: {persona.animalFavorito} ");

            Console.WriteLine("Gracias por su Colaboración");
            Console.ReadKey();
        }
        static int IngresarEdad()
        {
            Console.Write("Ingrese su edad: ");
            int edad1;
            while (true)
            {
                string edad = Console.ReadLine();
                if (!int.TryParse(edad, out edad1))
                {
                    Console.Write("Opción denegada ingrese un numero");
                }
                else
                {
                    break;
                }
            }
            return edad1;

        }
        static float IngresarEstatura()
        {
            Console.Write("Ingrese su estatura: ");
            float estatura1;
            while (true)
            {
                string estatura = Console.ReadLine();
                if (!float.TryParse(estatura, out estatura1))
                {
                    Console.Write("Opción denegada ingrese un numero decimal");
                }
                else
                {
                    break;
                }
            }
            return estatura1;

        }
    }
}
