using AliExpBusines.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliExpress
{
    interface ICargarDatos
    {
       List<Pedido> ObtenerPedidosTextoCSV();
    }
}
