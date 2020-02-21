using AliExpBusines.Entidades;
using CalculadorEntregas;
using ImpresorDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparadorPaqueterias
{
    public interface IConstructorPaqueteria
    {
        Pedido pedido { get; set; }
        IPaqueteria PrepararPaqueteria(IImprimible _impresor);
    }
}
