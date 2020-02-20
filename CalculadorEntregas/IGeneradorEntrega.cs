using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadorEntregas
{
    public interface IGeneradorEntrega
    {
        IPaqueteria GenerarPaqueteriayEnvio();
        bool esPaqueteriaValida { get; set; }

        bool esMetodoEnvioValido { get; set; }
    }
}
