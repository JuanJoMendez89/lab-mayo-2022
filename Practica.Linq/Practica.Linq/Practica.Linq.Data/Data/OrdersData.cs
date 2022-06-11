using Practica.Linq.Common.Exceptions;
using Practica.Linq.Data.Interfaces;
using Practica.Linq.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Linq.Data.Data
{
    public class OrdersData : BaseData, IAMBData<Orders, int>
    {
        public void Add(Orders entity)
        {
            try
            {
                if (_context.Orders.Any(c => c.OrderID == entity.OrderID))
                    throw new KeyDuplicadaException("Error de insercion, clave duplicada.", entity.OrderID.ToString());

                _context.Orders.Add(entity);

                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(int id)
        {
            Orders o = _context.Orders.Find(id);

            try
            {
                _context.Orders.Remove(o);

                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                _context.Entry(o).State = EntityState.Unchanged;
                throw ex;
            }
        }

        public List<Orders> GetAll()
        {
            return _context.Orders.ToList();
        }

        public Orders GetByID(int id)
        {
            return _context.Orders.Find(id);
        }

        public void Update(Orders entity)
        {
            Orders o = _context.Orders.Find(entity.OrderID);

            try
            {
                o.CustomerID = entity.CustomerID;
                o.EmployeeID = entity.EmployeeID;
                o.OrderDate = entity.OrderDate;
                o.RequiredDate = entity.RequiredDate;
                o.ShippedDate = entity.ShippedDate;
                o.ShipVia = entity.ShipVia;
                o.Freight = entity.Freight;
                o.ShipName = entity.ShipName;
                o.ShipAddress = entity.ShipAddress;
                o.ShipCity = entity.ShipCity;
                o.ShipRegion = entity.ShipRegion;
                o.ShipPostalCode = entity.ShipPostalCode;
                o.ShipCountry = entity.ShipCountry;
                o.Customers = entity.Customers;
                o.Employees = entity.Employees;
                o.Order_Details = entity.Order_Details;
                o.Shippers = entity.Shippers;

                _context.SaveChanges();

            }
            catch (Exception ex)
            {
                _context.Entry(o).State = EntityState.Unchanged;
                throw ex;
            }

        }
    }
}
