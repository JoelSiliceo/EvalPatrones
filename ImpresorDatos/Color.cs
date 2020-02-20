using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpresorDatos
{
    internal class Color : IColor
    {
        public void EstablecerColor(ConsoleColor _consoleColor)
        {
            Console.ForegroundColor = _consoleColor;
        }
    }
}
