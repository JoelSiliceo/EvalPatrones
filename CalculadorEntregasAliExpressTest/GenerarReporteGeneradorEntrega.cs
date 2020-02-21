using Microsoft.VisualStudio.TestTools.UnitTesting;
using AliExpress;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using CreadorFecha;

namespace AliExpress.Tests
{
    [TestClass()]
    public class GenerarReporteGeneradorEntrega
    {
        [TestMethod()]
        public void GeneraReporte_FechaAnterior_MensajeAnterior()
        {
            var DOCIGenerarFechaActual = new Mock<ICreadorFecha>();
            DateTime simulaHoy = Convert.ToDateTime("01/23/2020");
            DOCIGenerarFechaActual.Setup(f => f.GenerarFechaActual()).Returns(simulaHoy);

            Assert.Fail();
        }
    }
}