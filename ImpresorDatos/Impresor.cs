using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpresorDatos
{
    public class Impresor
    {
        private IImpresorDatos impresor;
        private IColor color;
        private string mensaje;

        public Impresor()
        {
            IColor color = new Color();
            impresor = new ImprimirConsola(color);
        }

        public void CambiarColor(ConsoleColor _color)
        {
            impresor.CambiarColor(_color);
        }

        public void CambiarMensaje(String mensaje)
        {
            impresor.CambiarMensaje(mensaje);
        }

        public void Imprimir()
        {
            this.impresor.Imprimir();
        }
    }
}
