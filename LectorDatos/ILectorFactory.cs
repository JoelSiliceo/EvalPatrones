using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectorDatos
{
    public interface ILectorFactory
    {
        ILectorDatos CrearLector();
    }
}
