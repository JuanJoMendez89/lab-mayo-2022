using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practica.EF.Entities.Entities;

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

            Shippers shippers = shippersLogic.GetByID(expected);

            actual = shippers.ShipperID;

            Assert.AreEqual(expected, actual);
        }
    }
}