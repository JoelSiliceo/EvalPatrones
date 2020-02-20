using System;
using System.Collections.Generic;

namespace CalculadorEntregas
{
    public interface IPaqueteria
    {
        List<IPaqueteria> competencia { get; set; }

        double CalcularCosto();

        DateTime CalcularEntrega();


        string Empresa();

    }
}
