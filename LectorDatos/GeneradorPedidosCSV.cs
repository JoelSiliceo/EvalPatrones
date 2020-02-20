using System.Collections.Generic;
using System;
using AliExpBusines.Entidades;

namespace LectorDatos
{
    public class GeneradorPedidosCSV : IGeneradorPedidos
    {
        private ILectorDatos lectorDatos;
        private string[] datos;
        private List<Pedido> lstPedidos;
        private char separador;
        public GeneradorPedidosCSV(ILectorDatos _lectorDatos, char _separador)
        {
            this.lectorDatos = _lectorDatos;
            this.lstPedidos = new List<Pedido>();
            this.separador = _separador;
        }

        public List<Pedido> GenerarPedidos()
        {
            try
            {
                this.ObtenerDatos();
                foreach (string linea in this.datos)
                {
                    AsignarPedido(linea);
                }
            }
            catch (Exception ex)
            {

                throw new Exception(string.Format("Error al cargar datos archivo. {0} ", ex.Message));
            }
            

            return lstPedidos;
        }

        private Pedido AsignarPedido(string linea)
        {

            Pedido pedidoNuevo = new Pedido();
            string[] datos = linea.Split(separador);

            pedidoNuevo.Origen = datos[0];
            pedidoNuevo.Destino = datos[1];
            pedidoNuevo.Distancia = int.Parse(datos[2]);
            pedidoNuevo.Paqueteria = datos[3];
            pedidoNuevo.MedioTranspote = datos[4];
            pedidoNuevo.FechaPedido = Convert.ToDateTime(datos[5]);


            lstPedidos.Add(pedidoNuevo);

            return pedidoNuevo;
        }

        private void ObtenerDatos()
        {
            this.datos = this.lectorDatos.LeerDatos();
        }


    }
}
