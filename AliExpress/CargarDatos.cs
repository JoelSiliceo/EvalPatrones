using AliExpBusines.Entidades;
using LectorDatos;
using System.Collections.Generic;

namespace AliExpress
{
    public class CargarDatos : ICargarDatos
    {
        IGeneradorPedidos generadorPedidos;
        public CargarDatos(string _ruta)
        {
            ILectorFactory lectorFactory = new LectorFactory(Entrada.Origen.Texto, _ruta);
            IGeneradoFactory generadoFactory = new GeneradorFactory(lectorFactory.CrearLector(), 
                                                                    Entrada.Formato.CSV, 
                                                                    ',');
            generadorPedidos = generadoFactory.GeneradorPedidos();
        }

        public List<Pedido> ObtenerPedidosTextoCSV()
        {
            return generadorPedidos.GenerarPedidos();
        }
    }
}
