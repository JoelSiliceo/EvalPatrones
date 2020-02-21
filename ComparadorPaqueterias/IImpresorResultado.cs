using AliExpBusines.Entidades;
using CalculadorEntregas;
using ImpresorDatos;


namespace ComparadorPaqueterias
{
    public interface IImpresorResultado
    {
        void Imprimir(IImprimible impresor, Pedido pedido, IPaqueteria paqueteria);
    }
}
