using AliExpBusines.Entidades;


namespace CalculadorEntregas.Entidades
{
    public class EstafetaTren : Paqueteria
    {
        public EstafetaTren(Pedido _pedido, int _costo, int _velocidad, int _margen) : base(_pedido, _costo, _velocidad, _margen)
        {

        }
    
    }
}
