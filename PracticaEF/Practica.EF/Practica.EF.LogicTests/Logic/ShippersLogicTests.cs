using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practica.EF.Entities.Entities;
using Practica.EF.Logic.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.EF.Logic.Logic.Tests
{
    [TestClass()]
    public class ShippersLogicTests
    {
        [TestMethod()]
        public void GetByIDTest()
        {
            ShippersLogic shippersLogic = new ShippersLogic();

            int expected = 1;
            int actual = 0;

            Shippers shippers = shippersLogic.GetByID(expected.ToString());

            actual = shippers.ShipperID;

            Assert.AreEqual(expected, actual);
        }
    }
}