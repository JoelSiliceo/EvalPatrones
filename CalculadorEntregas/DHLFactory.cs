using AliExpBusines.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadorEntregas
{
    class DHLFactory : IMetodosEntrega
    {
        private Pedido pedido;

        public DHLFactory(Pedido _pedido)
        {
            this.pedido = _pedido;
        }

        public IPaqueteria CrearConAvion()
        {
            return new Entidades.DHLAvion(pedido, 10, 600, 40);
        }

        public IPaqueteria CrearConBarco()
        {
            return new Entidades.DHLBarco(pedido,1,46,40);
        }

        public IPaqueteria CrearConTren()
        {
            return null;
        }
    }
}
