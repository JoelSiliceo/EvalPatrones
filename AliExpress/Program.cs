using AliExpBusines.Entidades;
using System.Collections.Generic;

namespace AliExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            ICargarDatos cargaDatos = new CargarDatos("datosPedidos.txt");
            List<Pedido> pedidos = cargaDatos.ObtenerPedidosTextoCSV();
            IGenerarReporte generarReporte = new GenerarReporte(pedidos);
            generarReporte.GeneraReporte();

            System.Console.ReadLine();
        }
    }
}
