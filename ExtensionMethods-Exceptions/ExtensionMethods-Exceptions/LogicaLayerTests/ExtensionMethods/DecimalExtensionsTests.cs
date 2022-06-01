using Microsoft.VisualStudio.TestTools.UnitTesting;
using LogicaLayer.ExtensionMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaLayer.ExtensionMethods.Tests
{
    [TestClass()]
    public class DecimalExtensionsTests
    {
        [TestMethod()]
        public void DividirTest()
        {
            decimal valor = 8;
            decimal valor2 = 2;
            decimal resultadoEsperado = 4;

            decimal resultadoActual = valor.Dividir(valor2);

            Assert.AreEqual(resultadoEsperado, resultadoActual);
        }
    }
}