using Tarea3DependencyInyection.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3DependencyInyection
{
    public class PagoConTarjeta: IPay
    {
        public string Pay(Sale _data)
        {
            return $"Pago con tarjeta {_data.NumeroDeTarjeta} exitoso, monto {_data.Amount}";
        }
    }
}
