using System.Linq;
namespace TareaArboles
{
    internal class ExaminarArbol
    {
        internal int ContarLasHojas(Nodo nodo)
        {
            int acumulador = 0;
            foreach (Nodo existe in nodo.Hijos)
            {
                acumulador += existe.Valor.Count() + existe.Hijos.Count();
            }
            return acumulador;
        }

        internal int ContarLosNodos(Nodo nodo)
        {
            int acumulador = 0;
            acumulador += nodo.nodoRaiz + nodo.Hijos.Count();
            foreach (Nodo existe in nodo.Hijos)
            {
                acumulador += existe.Hijos.Count;
            }
            return acumulador;
        }

        internal int ContarLosNiveles(Nodo nodo)
        {
            int acumulador = 0;
            foreach (Nodo existe in nodo.Hijos)
            {
                acumulador += existe.Valor.Count();
            }
            return acumulador;
        }

    }
}