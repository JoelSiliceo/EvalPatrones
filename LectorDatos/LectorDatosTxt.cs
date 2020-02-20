using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectorDatos
{
    internal class LectorDatosTxt : ILectorDatos
    {
        private string ruta;

        public  LectorDatosTxt(string _ruta)
        {
            this.ruta = _ruta;
        }

        public string[] LeerDatos()
        {
            string[] datos = System.IO.File.ReadAllLines(this.ruta);

            return datos;
        }
    }
}
