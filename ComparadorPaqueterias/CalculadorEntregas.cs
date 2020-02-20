using AliExpBusines.Entidades;
using CalculadorEntregas;
using CreadorFecha;
using ImpresorDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparadorPaqueterias
{
    public class CalculadorEntregas
    {
        private ICreadorFecha creadorFecha;
        private List<Pedido> pedidos;

        public CalculadorEntregas(List<Pedido> _pedidos, ICreadorFecha _creadorFecha)
        {
            this.pedidos = _pedidos;
            this.creadorFecha = _creadorFecha;
        }

        public void CalcularEntregas()
        {
            ConstructorPaqueteria ctorPaqueteria = new ConstructorPaqueteria();
            Impresor impresor = new Impresor();
            ImpresorResultado impResultado = new ImpresorResultado(creadorFecha);
            Comparador comparador = new Comparador();
                 
            IPaqueteria paqueteria;

            foreach (Pedido pedido in this.pedidos)
            {
                ctorPaqueteria.pedido = pedido;

                paqueteria = ctorPaqueteria.PrepararPaqueteria(impresor);
                if (paqueteria != null)
                {
                    impResultado.Imprimir(impresor, pedido, paqueteria);
                    comparador.Compara(impresor, paqueteria);
                }
            }
        }
    }
}
