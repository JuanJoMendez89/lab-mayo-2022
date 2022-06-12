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
    public class ProductsData : BaseData, IAMBData<Products, int>
    {
        public void Add(Products entity)
        {
            try
            {
                if (_context.Products.Any(c => c.ProductID == entity.ProductID))
                    throw new KeyDuplicadaException("Error de insercion, clave duplicada.", entity.ProductID.ToString());

                _context.Products.Add(entity);

                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(int id)
        {
            Products p = _context.Products.Find(id);

            try
            {
                _context.Products.Remove(p);

                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                _context.Entry(p).State = EntityState.Unchanged;
                throw ex;
            }
        }

        public List<Products> GetAll()
        {
            return _context.Products.ToList();
        }

        public Products GetByID(int id)
        {
            return _context.Products.Find(id);
        }

        public void Update(Products entity) 
        { 
            Products p = _context.Products.Find(entity.ProductID);

            try
            {
                p.ProductName = entity.ProductName;
                p.SupplierID = entity.SupplierID;
                p.CategoryID = entity.CategoryID;
                p.QuantityPerUnit = entity.QuantityPerUnit;
                p.UnitPrice = entity.UnitPrice;
                p.UnitsInStock = entity.UnitsInStock;
                p.UnitsOnOrder = entity.UnitsOnOrder;
                p.ReorderLevel = entity.ReorderLevel;
                p.Discontinued = entity.Discontinued;
                p.Categories = entity.Categories;
                p.Order_Details = entity.Order_Details;

                _context.SaveChanges();

            }
            catch (Exception ex)
            {
                _context.Entry(p).State = EntityState.Unchanged;
                throw ex;
            }

        }

        public List<Products> GetProductosSinStock()
        {
            return _context.Products.Where(p => p.UnitsInStock < 1).ToList();
        }

        public List<Products> GetProductosConStock()
        {
            return _context.Products.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3).ToList();
        }

        public Products GetProducto789()
        {
            // Lo hice asi porque dudaba de la consigna, tambien podria haber usado el metodo GetByID pasando parametro 789.
            return (from p in _context.Products
                    where p.ProductID == 789
                    select p).FirstOrDefault();
        }

        public List<Products> GetAllOrdenadosPorNombre()
        {
            return _context.Products.OrderBy(p => p.ProductName).ToList();
        }

        public List<Products> GetAllOrdenadosPorUnitInStock()
        {
            return (from p in _context.Products
                    orderby p.UnitsInStock descending
                    select p).ToList();
        }

        public Products GetPrimerProduct()
        {
            return (from p in _context.Products
                    select p).Take(1).SingleOrDefault();
        }

    }
}
