using Tarea3DependencyInyection.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3DependencyInyection
{
    class VerificacionDelPago
    {
        IPay _Pay;
        public VerificacionDelPago(IPay Pay)
        {
            _Pay = Pay;
        }
        public string GenerarPago(Sale _data)
        {
            return _Pay.Pay(_data);
        }

    }
}
