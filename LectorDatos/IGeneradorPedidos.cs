using System.Collections.Generic;
using AliExpBusines.Entidades;


namespace LectorDatos
{
    public interface IGeneradorPedidos
    {
        
        List<Pedido> GenerarPedidos();
    }
}
