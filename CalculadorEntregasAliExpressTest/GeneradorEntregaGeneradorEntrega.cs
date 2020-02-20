using AliExpBusines.Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace CalculadorEntregas.Tests
{
    [TestClass()]
    public class GeneradorEntregaGeneradorEntrega
    {

        [TestMethod()]
        public void GenerarPaqueteria_PaqueteriaYMetodoCorrectos_ObjDHLAvion()
        {
            //ARRANGE
            Pedido pedido = new Pedido();
            pedido.MedioTranspote = "AVION";
            pedido.Paqueteria = "DHL";
            IGeneradorEntrega generadorEntrega = new GeneradorEntrega(pedido);

            //ACT
            var SUT = generadorEntrega.GenerarPaqueteriayEnvio();

            //ASSERT
            Assert.AreEqual(typeof(Entidades.DHLAvion), SUT.GetType());
        }

        [TestMethod()]
        public void GenerarPaqueteria_PaqueteriaError_false()
        {
            //ARRANGE
            Pedido pedido = new Pedido();
            pedido.Paqueteria = "REDPACK";
            IGeneradorEntrega generadorEntrega = new GeneradorEntrega(pedido);

            //ACT
            var SUT = generadorEntrega.esPaqueteriaValida;

            //ASSERT
            Assert.AreEqual(false, SUT);
        }

        [TestMethod()]
        public void GenerarPaqueteria_MetodoError_false()
        {
            //ARRANGE
            Pedido pedido = new Pedido();
            pedido.MedioTranspote = "BURRO";
            IGeneradorEntrega generadorEntrega = new GeneradorEntrega(pedido);

            //ACT
            var SUT = generadorEntrega.esMetodoEnvioValido;

            //ASSERT
            Assert.AreEqual(false, SUT);
        }

        [TestMethod()]
        public void GenerarPaqueteria_PaqueteriaErrorYMetodoError_null()
        {
            //ARRANGE
            Pedido pedido = new Pedido();
            pedido.MedioTranspote = "MOTO";
            pedido.Paqueteria = "SEPOMEX";
            IGeneradorEntrega generadorEntrega = new GeneradorEntrega(pedido);

            //ACT
            var SUT = generadorEntrega.GenerarPaqueteriayEnvio();

            //ASSERT
            Assert.AreEqual(null, SUT);
        }
    }
}