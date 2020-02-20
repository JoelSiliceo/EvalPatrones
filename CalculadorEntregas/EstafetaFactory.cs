
using AliExpBusines.Entidades;

namespace CalculadorEntregas
{
    class EstafetaFactory : IMetodosEntrega
    {
        private Pedido pedido;

        public EstafetaFactory(Pedido _pedido)
        {
            this.pedido = _pedido;
        }

        public IPaqueteria CrearConAvion()
        {
            return null;
        }

        public IPaqueteria CrearConBarco()
        {
            return new Entidades.EstafetaBarco(pedido,1,46,20);
        }

        public IPaqueteria CrearConTren()
        {
            return new Entidades.EstafetaTren(pedido, 5 , 80, 20);
        }
    }
}
