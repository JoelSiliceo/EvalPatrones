using AliExpBusines.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadorEntregas
{
    public class GeneradorEntrega : IGeneradorEntrega
    {
        private Pedido pedido;
        private IPaqueteria paqueteria;
        private IMetodosEntrega metodoEntrega;
        public bool esPaqueteriaValida { get; set; }

        public bool esMetodoEnvioValido { get; set; }

        public GeneradorEntrega(Pedido _pedido)
        {
            this.pedido = _pedido;
            metodoEntrega = this.GenerarPaqueteria();
        }

        public IPaqueteria GenerarPaqueteriayEnvio()
        {
            this.esMetodoEnvioValido = true;
            IPaqueteria paqueteria = null;
            if (esPaqueteriaValida)
            {
                switch (this.pedido.MedioTranspote.ToUpper())
                {
                    case "TREN":
                        paqueteria = metodoEntrega.CrearConTren();
                        break;
                    case "BARCO":
                        paqueteria = metodoEntrega.CrearConBarco();
                        break;
                    case "AVION":
                        paqueteria = metodoEntrega.CrearConAvion();
                        break;
                }
            }
            if (paqueteria == null) this.esMetodoEnvioValido = false;

            return paqueteria;
        }

       

        private IMetodosEntrega GenerarPaqueteria()
        {
            esPaqueteriaValida = true;
            switch (pedido.Paqueteria.ToUpper())
            {
                case "ESTAFETA":
                    return new EstafetaFactory(pedido);
                case "FEDEX":
                    return new FedexFactory(pedido);
                case "DHL":
                    return new DHLFactory(pedido);
            }
            esPaqueteriaValida = false;
            return null;
        }

    }
}
