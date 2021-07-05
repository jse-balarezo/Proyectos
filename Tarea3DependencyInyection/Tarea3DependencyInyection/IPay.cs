using Tarea3DependencyInyection.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3DependencyInyection
{
    public interface IPay
    {
        string Pay(Sale _data);
    }
}
