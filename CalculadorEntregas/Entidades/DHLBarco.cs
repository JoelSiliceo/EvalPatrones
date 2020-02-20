using AliExpBusines.Entidades;

namespace CalculadorEntregas.Entidades
{
    public class DHLBarco :Paqueteria
    {
        public DHLBarco(Pedido _pedido, int _costo, int _velocidad, int _margen) : base(_pedido, _costo, _velocidad, _margen)
        {

        }
    }
}
