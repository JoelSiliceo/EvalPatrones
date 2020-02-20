

using AliExpBusines.Entidades;

namespace CalculadorEntregas.Entidades
{
    public class EstafetaBarco : Paqueteria
    {
        public EstafetaBarco(Pedido _pedido, int _costo, int _velocidad, int _margen) : base(_pedido, _costo, _velocidad, _margen)
        {

        }
    }
}
