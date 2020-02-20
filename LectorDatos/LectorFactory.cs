using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectorDatos
{
    public class LectorFactory : ILectorFactory
    {
        private Entrada.Origen origen;
        private string ruta;

        public LectorFactory(Entrada.Origen _origen, string _ruta)
        {
            this.origen = _origen;
            this.ruta = _ruta;
        }

        public ILectorDatos CrearLector()
        {
            switch (this.origen)
            {
                case Entrada.Origen.Texto:
                    return new LectorDatosTxt(this.ruta);
            }

            throw new Exception("Origen de datos no válido");
        }
    }
}
