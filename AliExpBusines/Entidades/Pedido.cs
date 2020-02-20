using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliExpBusines.Entidades
{
    public class Pedido
    {
        public string Origen { get; set; }

        public string Destino { get; set; }

        public int Distancia { get; set; }

        public string Paqueteria { get; set; }

        public string MedioTranspote { get; set; }

        public DateTime FechaPedido { get; set; }
    }
}
