using CalculadorEntregas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpresorDatos
{
    internal class ImprimirConsola : IImpresorDatos
    {
        private String mensaje;
        private IColor color;

        public ImprimirConsola(IColor _color)
        {
            this.color = _color;
        }

        public void CambiarColor(ConsoleColor _color)
        {
            this.color.EstablecerColor(_color);
        }

        public void CambiarMensaje(string _mensaje)
        {
            this.mensaje = _mensaje;
        }

        public void Imprimir()
        {
            Console.WriteLine(this.mensaje);
        }
    }
}
