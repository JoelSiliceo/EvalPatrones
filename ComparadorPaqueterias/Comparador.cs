using CalculadorEntregas;
using ImpresorDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparadorPaqueterias
{
    public class Comparador
    {

        public void Compara(Impresor impresor, IPaqueteria paqueteria)
        {
            double miPrecio = paqueteria.CalcularCosto();
            double otroPrecio = 0;
            foreach(IPaqueteria competencia in paqueteria.competencia)
            {
                if (competencia != null)
                {
                    otroPrecio = competencia.CalcularCosto();
                    if (otroPrecio < miPrecio)
                    {
                        impresor.CambiarMensaje(String.Format("Si hubieras pedido en {0} " +
                            "te hubiera costado {1}.", competencia.Empresa(), otroPrecio));
                        impresor.CambiarColor(ConsoleColor.White);
                        impresor.Imprimir();
                    }
                }
            }
        }
    }
}
