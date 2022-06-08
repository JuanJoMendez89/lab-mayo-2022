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
    public class CustomersLogicTests
    {
        // Este test solo funciona si el registro no existe en la bd
        // Ya que la columna CustomerID es Unique Key.
        [TestMethod()]
        public void AddTest()
        {
            CustomersLogic logic = new CustomersLogic();

            Customers customer = new Customers
            {
                CustomerID = "ZTEST",
                CompanyName = "ZTEST",
                ContactName = "ZTEST",
                ContactTitle = "ZTEST",
                Address = "ZTEST 1234",
                City = "Rosario",
                Region = "Planeta tierra",
                Country = "Argentina",
                PostalCode = "2000",
                Phone = "3413445566",
                Fax = "3413445566",
            };

            logic.Add(customer);

            Assert.AreEqual(customer, logic.GetByID(customer.CustomerID));
        }
    }
}