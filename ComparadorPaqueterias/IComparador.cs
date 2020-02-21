using CalculadorEntregas;
using ImpresorDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparadorPaqueterias
{
    public interface IComparador
    {
        void Compara(IImprimible impresor, IPaqueteria paqueteria);
    }
}
