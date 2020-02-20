using AliExpBusines.Entidades;
using System.Collections.Generic;

namespace AliExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            CargarDatos cargaDatos = new CargarDatos("datosPedidos.txt");
            List<Pedido> pedidos = cargaDatos.ObtenerPedidosTextoCSV();
            GenerarReporte generarReporte = new GenerarReporte(pedidos);
            generarReporte.GeneraReporte();

            System.Console.ReadLine();
        }
    }
}
