using System;
using Unity;

namespace Tarea3DependencyInyection
{
    class Program
    {
        static VerificacionDelPago _verificaciónPagos;
        static void Main(string[] args)
        {
            Init();
            Console.WriteLine("Enviado Pago");
            Console.WriteLine(_verificaciónPagos.GenerarPago(new DTO.Sale { Amount = 10, NumeroDeTarjeta = "2214526372" }));

            Console.WriteLine(_verificaciónPagos.GenerarPago(new DTO.Sale { Amount = 130, NumeroDeTarjeta = "134564526378" }));
            Console.ReadKey();
        }
        static void Init()
        {
            var _container = new UnityContainer();
            _container.RegisterType<IPay, PagoConPayPal>();
            _verificaciónPagos = _container.Resolve<VerificacionDelPago>();
        }
    }
}
