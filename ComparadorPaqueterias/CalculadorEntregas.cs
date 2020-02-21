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
    public class CalculadorEntregas : ICalculadorEntrega
    {
        private IConstructorPaqueteria ctorPaqueteria ;
        private IImprimible impresor ;
        private ImpresorResultado impResultado ;
        private IComparador comparador ;
        private ICreadorFecha creadorFecha;
        private List<Pedido> pedidos;

        public CalculadorEntregas(List<Pedido> _pedidos, ICreadorFecha _creadorFecha,
                                  IConstructorPaqueteria _ctorPaqueteria,
                                  IImprimible _impresor,
                                  ImpresorResultado _impResultado,
                                  IComparador _comparador)
        {
            this.pedidos = _pedidos;
            this.creadorFecha = _creadorFecha;
            this.ctorPaqueteria = _ctorPaqueteria;
            this.impresor = _impresor;
            this.impResultado =_impResultado;
            this.comparador = _comparador;
        }

        public void CalcularEntregas()
        {
                 
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
