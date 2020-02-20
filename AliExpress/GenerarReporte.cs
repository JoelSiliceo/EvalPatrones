using AliExpBusines.Entidades;
using CreadorFecha;
using System.Collections.Generic;


namespace AliExpress
{
    public class GenerarReporte
    {
        List<Pedido> pedidos;

        public GenerarReporte(List<Pedido> _pedidos)
        {
            this.pedidos = _pedidos;
        }

        public void GeneraReporte()
        {
            ICreadorFecha creadorFecha = new CreadorFecha.CreadorFecha();
            ComparadorPaqueterias.CalculadorEntregas calcEntrega = new ComparadorPaqueterias.CalculadorEntregas(this.pedidos, creadorFecha);

            calcEntrega.CalcularEntregas();
        }
    }
}
