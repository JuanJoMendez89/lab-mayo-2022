using Microsoft.VisualStudio.TestTools.UnitTesting;
using LogicaLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicaLayer.Exceptions;

namespace LogicaLayer.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void DispararExcepcionPersonalizadaTest()
        {
            Action action = Logic.DispararExcepcionPersonalizada;

            Assert.ThrowsException<ExcesoDeFachaException>(action);
        }
    }
}