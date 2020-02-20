using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectorDatos
{
    public class GeneradorFactory : IGeneradoFactory
    {
        private Entrada.Formato formato;
        private char separador;
        private ILectorDatos lectorDatos;

        public GeneradorFactory(ILectorDatos _lectosDatos, Entrada.Formato _formato, char _separador)
        {
            this.formato = _formato;
            this.separador = _separador;
            this.lectorDatos = _lectosDatos;
        }
        public IGeneradorPedidos GeneradorPedidos()
        {
            switch (this.formato)
            {
                case Entrada.Formato.CSV:
                    return new GeneradorPedidosCSV(this.lectorDatos, this.separador);
            }

            throw new Exception("Formato de archivo no válido");
        }
    }
}
