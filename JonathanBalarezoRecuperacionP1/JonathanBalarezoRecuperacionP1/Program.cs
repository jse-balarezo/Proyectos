using System;
using System.Collections.Generic;
using System.Linq;

namespace JonathanBalarezoRecuperacionP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola arupo");

            Nodo raiz = new Nodo()
            {

                Valor = "1",
                Hijos ={
                    new Nodo{
                        Valor="2",
                        Hijos={
                            new Nodo{
                                Valor="4"
                            },
                            new Nodo{
                                Valor ="5",
                                Hijos =
                                {
                                    new Nodo
                                    {
                                        Valor="8"
                                    }
                                }
                            },

                        }
                    },

                    new Nodo{
                        Valor ="3",
                        Hijos={
                            new Nodo{
                                Valor="6",
                                Hijos =
                                {
                                    new Nodo
                                    {
                                        Valor="9"
                                    }
                                }
                            },
                            new Nodo{
                                Valor="7"
                            },

                        }
                    },


                },
            };
            //RESULTADO ESPERADO 8*5
            ManejadorArbol manejadorArbol = new ManejadorArbol();
            Console.WriteLine(manejadorArbol.ImprimirArbol(raiz));
        }
    }
    class ManejadorArbol
    {
        public string ImprimirArbol(Nodo nodo)
        {
            if (!nodo.Hijos.Any())
                
            {
                //return ImprimirArbol(nodo.Hijos[0]) + nodo.Valor + ImprimirArbol(nodo.Hijos[1]);
                return ImprimirArbol(nodo.Hijos[0])
               + ImprimirArbol(nodo.Hijos[1])
               + ImprimirArbol(nodo.Hijos[2])
               + ImprimirArbol(nodo.Hijos[3])
               + ImprimirArbol(nodo.Hijos[4])
               + ImprimirArbol(nodo.Hijos[5])
               + ImprimirArbol(nodo.Hijos[6])
               + ImprimirArbol(nodo.Hijos[7])
               + ImprimirArbol(nodo.Hijos[8]);
            }

            throw new NotImplementedException();
        }
    }


    class Nodo
    {
        public int Id { get; set; } 
        public string Valor { get; set; }
        public List<Nodo> Hijos { get; set; } = new List<Nodo>();
    }

}
