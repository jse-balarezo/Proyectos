using System;

namespace TareaArboles
{
    class Program
    {
        static void Main(string[] args)
        {
            Nodo raiz = new Nodo()
            {

                Valor = "/",
                nivel = 0,
                Hijos ={
                    new Nodo{
                        Valor="*",
                        Hijos={
                            new Nodo{
                                Valor="8"
                            },
                            new Nodo{
                                Valor ="5"
                            },
                            new Nodo{
                                Valor ="9"
                            }
                        }
                    },

                    new Nodo{
                        Valor ="-",
                        Hijos={
                            new Nodo{
                                Valor="2"
                            },
                            new Nodo{
                                Valor="9"
                            },
                            new Nodo{
                                Valor ="1"
                            },
                            new Nodo{
                                Valor ="7"
                            }
                        }
                    },

                    new Nodo{
                        Valor="+",
                        Hijos={
                            new Nodo{
                                Valor="3"
                            },
                            new Nodo{
                                Valor="4"
                            },
                            new Nodo{
                                Valor ="6"
                            }

                        }
                    }
                },
            };

            ExaminarArbol ExaminarArbol = new ExaminarArbol();
            Console.WriteLine($"El Arbol Tiene : {ExaminarArbol.ContarLasHojas(raiz)} Hojas");
            Console.WriteLine($"El Arbol Tiene : {ExaminarArbol.ContarLosNiveles(raiz)} Niveles");
            Console.WriteLine($"El Arbol Tiene : {ExaminarArbol.ContarLosNodos(raiz)} Nodos");


        }
    }
}
