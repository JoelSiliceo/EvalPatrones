using AliExpBusines.Entidades;
using CalculadorEntregas;
using ImpresorDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparadorPaqueterias
{

    public class ConstructorPaqueteria
    {
        public Pedido pedido { get; set; }
        private Impresor impresor;

        public IPaqueteria PrepararPaqueteria(Impresor _impresor)
        {
            this.impresor = _impresor;
            IGeneradorEntrega generador = new GeneradorEntrega(this.pedido);
            IPaqueteria paqueteria = generador.GenerarPaqueteriayEnvio();
            if (!this.ValidarPaqueteria(generador)) return null;
            if (!this.ValidarMetodoEntrega(generador)) return null;
                        

            GenerarCompetidoresViolandoSOLID(paqueteria);
            
            return paqueteria;
        }

        private void GenerarCompetidoresViolandoSOLID(IPaqueteria paqueteria)
        {
            if (this.pedido.Paqueteria.ToUpper().Equals("DHL"))
            {
                Pedido pedidoFedex = this.ClonarPedido(this.pedido);
                Pedido pedidoEstafeta = this.ClonarPedido(this.pedido);

                pedidoFedex.Paqueteria = "FEDEX";
                pedidoEstafeta.Paqueteria = "ESTAFETA";
                GeneradorEntrega generador = new GeneradorEntrega(pedidoFedex);
                paqueteria.competencia.Add(generador.GenerarPaqueteriayEnvio());
                generador = new GeneradorEntrega(pedidoEstafeta);
                paqueteria.competencia.Add(generador.GenerarPaqueteriayEnvio());
            }

            if (this.pedido.Paqueteria.ToUpper().Equals("FEDEX"))
            {
                Pedido pedidoDHL = this.ClonarPedido(this.pedido);
                Pedido pedidoEstafeta = this.ClonarPedido(this.pedido);

                pedidoDHL.Paqueteria = "DHL";
                pedidoEstafeta.Paqueteria = "ESTAFETA";
                GeneradorEntrega generador = new GeneradorEntrega(pedidoDHL);
                paqueteria.competencia.Add(generador.GenerarPaqueteriayEnvio());
                generador = new GeneradorEntrega(pedidoEstafeta);
                paqueteria.competencia.Add(generador.GenerarPaqueteriayEnvio());
            }


            if (this.pedido.Paqueteria.ToUpper().Equals("ESTAFETA"))
            {
                Pedido pedidoFedex = this.ClonarPedido(this.pedido);
                Pedido pedidoDHL = this.ClonarPedido(this.pedido);

                pedidoFedex.Paqueteria = "FEDEX";
                pedidoDHL.Paqueteria = "DHL";
                GeneradorEntrega generador = new GeneradorEntrega(pedidoFedex);
                paqueteria.competencia.Add(generador.GenerarPaqueteriayEnvio());
                generador = new GeneradorEntrega(pedidoDHL);
                paqueteria.competencia.Add(generador.GenerarPaqueteriayEnvio());
            }
        }

        private Pedido ClonarPedido(Pedido pedido)
        {
            Pedido clon = new Pedido();
            clon.Destino = pedido.Destino;
            clon.Distancia = pedido.Distancia;
            clon.FechaPedido = pedido.FechaPedido;
            clon.MedioTranspote = pedido.MedioTranspote;
            clon.Origen = pedido.Origen;
            clon.Paqueteria = pedido.Paqueteria;

            return clon;
        }

        private bool ValidarPaqueteria(IGeneradorEntrega generador)
        {
            if (!generador.esPaqueteriaValida)
            {
                this.impresor.CambiarColor(ConsoleColor.Red);
                this.impresor.CambiarMensaje(String.Format("La Paquetería: {0} " +
                    "no se encuentra registrada en nuestra red de distribución.", this.pedido.Paqueteria));
                this.impresor.Imprimir();
                return false;
            }

            return true;
        }

        private bool ValidarMetodoEntrega(IGeneradorEntrega _generador)
        {
            if (!_generador.esMetodoEnvioValido)
            {
                this.impresor.CambiarColor(ConsoleColor.Red);
                this.impresor.CambiarMensaje(String.Format("{0} no ofrece el servicio de transporte " +
                                            " {1}, te recomendamos cotizar en otra empresa.", pedido.Paqueteria, pedido.MedioTranspote));
                this.impresor.Imprimir();
                
                return false;
            }

            return true;
        }
    }
}
