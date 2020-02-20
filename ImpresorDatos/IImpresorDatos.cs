using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpresorDatos
{
    interface IImpresorDatos
    {
        void CambiarColor(ConsoleColor _color);
        void CambiarMensaje(string _mensaje);
        void Imprimir();
    }
}
