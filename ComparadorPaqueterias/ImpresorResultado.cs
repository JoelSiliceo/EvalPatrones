using AliExpBusines.Entidades;
using CalculadorEntregas;
using CreadorFecha;
using ImpresorDatos;
using System;


namespace ComparadorPaqueterias
{
    public class ImpresorResultado
    {
        private ICreadorFecha creadorFecha;

        public ImpresorResultado(ICreadorFecha _creadorFecha)
        {
            this.creadorFecha = _creadorFecha;
        }

        public  void Imprimir(Impresor impresor, Pedido pedido, IPaqueteria paqueteria)
        {
            impresor.CambiarMensaje(this.GenerarMensajePorFecha(pedido, paqueteria));
            if (paqueteria.CalcularEntrega() < this.creadorFecha.GenerarFechaActual())
            {
                impresor.CambiarColor(ConsoleColor.Green);
            }
            else
            {
                impresor.CambiarColor(ConsoleColor.Yellow);
            }
            impresor.Imprimir();
        }

        private String GenerarMensajePorFecha(Pedido pedido, IPaqueteria paqueteria)
        {
            String mensaje = "Tu paquete {0} de {1} y {2} a {3} el {4} y {5} un costo de {6} (Cualquier reclamación con {7}).";
            String exp1 = string.Empty;
            String exp2 = string.Empty;
            String exp3 = string.Empty;
            double costo = paqueteria.CalcularCosto();
            DateTime fechaEntrega = paqueteria.CalcularEntrega();

            if (fechaEntrega < this.creadorFecha.GenerarFechaActual())
            {
                exp1 = "salió";
                exp2 = "llegó";
                exp3 = "tuvo";
            }
            else
            {
                exp1 = "ha salido";
                exp2 = "llegará";
                exp3 = "tendrá";
            }

            return String.Format(mensaje, exp1, pedido.Origen, exp2, pedido.Destino, fechaEntrega, exp3, costo.ToString(), pedido.Paqueteria);
        }

    }
}
