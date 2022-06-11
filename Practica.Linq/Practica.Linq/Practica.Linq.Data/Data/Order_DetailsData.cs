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
    public class Order_DetailsData : BaseData, IAMBData<Order_Details, int>
    {
        public void Add(Order_Details entity)
        {

            try
            {
                if (_context.Order_Details.Any(c => c.OrderID == entity.OrderID))
                    throw new KeyDuplicadaException("Error de insercion, clave duplicada.", entity.OrderID.ToString());

                _context.Order_Details.Add(entity);

                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void Delete(int id)
        {
            Order_Details o = _context.Order_Details.Find(id);

            try
            {
                _context.Order_Details.Remove(o);

                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                _context.Entry(o).State = EntityState.Unchanged;
                throw ex;
            }
        }

        public List<Order_Details> GetAll()
        {
            return _context.Order_Details.ToList();
        }

        public Order_Details GetByID(int id)
        {
            return _context.Order_Details.Find(id);
        }

        public void Update(Order_Details entity)
        {
            Order_Details o = _context.Order_Details.Find(entity.OrderID);

            try
            {
                o.ProductID = entity.ProductID;
                o.UnitPrice = entity.UnitPrice;
                o.Quantity = entity.Quantity;
                o.Discount = entity.Discount;
                o.Orders = entity.Orders;
                o.Products = entity.Products;
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
