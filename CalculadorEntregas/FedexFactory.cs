using AliExpBusines.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadorEntregas
{
    class FedexFactory : IMetodosEntrega
    {
        private Pedido pedido;

        public FedexFactory(Pedido _pedido)
        {
            this.pedido = _pedido;
        }

        public IPaqueteria CrearConAvion()
        {
            return null;
        }

        public IPaqueteria CrearConBarco()
        {
            return new Entidades.FedexBarco(this.pedido, 1, 46, 50);
        }

        public IPaqueteria CrearConTren()
        {
            return null;
        }
    }
}
