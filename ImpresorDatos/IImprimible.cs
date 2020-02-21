using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpresorDatos
{
    public interface IImprimible
    {
        void CambiarColor(ConsoleColor _color);

        void CambiarMensaje(String mensaje);

        void Imprimir();
        
    }
}
