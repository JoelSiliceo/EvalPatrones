using AliExpBusines.Entidades;
using ComparadorPaqueterias;
using CreadorFecha;
using ImpresorDatos;
using System.Collections.Generic;



namespace AliExpress
{
    public class GenerarReporte : IGenerarReporte
    {
        List<Pedido> pedidos;

        public GenerarReporte(List<Pedido> _pedidos)
        {
            this.pedidos = _pedidos;
        }

        public void GeneraReporte()
        {
            ICreadorFecha creadorFecha = new CreadorFecha.CreadorFecha();
            IConstructorPaqueteria ctorPaqueteria = new ConstructorPaqueteria();
            IImprimible impresor = new Impresor();
            ImpresorResultado impResultado = new ImpresorResultado(creadorFecha);
            IComparador comparador = new Comparador();
            ComparadorPaqueterias.ICalculadorEntrega calcEntrega = new ComparadorPaqueterias.CalculadorEntregas(this.pedidos, creadorFecha,
                ctorPaqueteria, impresor, impResultado, comparador);

            calcEntrega.CalcularEntregas();
        }
    }
}
