using AliExpBusines.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadorEntregas.Entidades
{
    public abstract class Paqueteria : IPaqueteria
    {
        private int costo;
        private int velocidad;
        private int margen;
        private Pedido pedido;

        public List<IPaqueteria> competencia { get; set; }

        public Paqueteria(Pedido _pedido, int _costo, int _velocidad, int _margen)
        {
            this.competencia = new List<IPaqueteria>();
            this.pedido = _pedido;
            this.costo = _costo;
            this.velocidad = _velocidad;
            this.margen = _margen;
        }

        public virtual double CalcularCosto()
        {
            int tiempoTraslado = CalcularTiempo();

            double costo = Convert.ToDouble(this.costo) * Convert.ToDouble(this.pedido.Distancia) * ((1 + Convert.ToDouble(this.margen)) / 100);

            return costo;
        }

        public virtual DateTime CalcularEntrega()
        {
            
            int tiempoTraslado = CalcularTiempo();

            DateTime entrega = pedido.FechaPedido.AddHours(tiempoTraslado);

            return entrega;
        }

        

        public virtual String Empresa()
        {
            return pedido.Paqueteria;
        }

        private int CalcularTiempo()
        {
            return pedido.Distancia / this.velocidad;
        }
    }
}
