using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreadorFecha
{
    public class CreadorFecha : ICreadorFecha
    {
        public DateTime GenerarFechaActual()
        {
            return DateTime.Now;
        }
    }
}
