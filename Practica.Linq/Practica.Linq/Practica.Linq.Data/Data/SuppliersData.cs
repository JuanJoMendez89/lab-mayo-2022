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
    public class SuppliersData : BaseData, IAMBData<Suppliers, int>
    {
        public void Add(Suppliers entity)
        {
            try
            {
                if (_context.Suppliers.Any(c => c.SupplierID == entity.SupplierID))
                    throw new KeyDuplicadaException("Error de insercion, clave duplicada.", entity.SupplierID.ToString());

                _context.Suppliers.Add(entity);

                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(int id)
        {
            Suppliers s = _context.Suppliers.Find(id);

            try
            {
                _context.Suppliers.Remove(s);

                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                _context.Entry(s).State = EntityState.Unchanged;
                throw ex;
            }
        }

        public List<Suppliers> GetAll()
        {
            return _context.Suppliers.ToList();
        }

        public Suppliers GetByID(int id)
        {
            return _context.Suppliers.Find(id);
        }

        public void Update(Suppliers entity)
        {
            Suppliers s = _context.Suppliers.Find(entity.SupplierID);

            try
            {
                s.CompanyName = entity.CompanyName;
                s.ContactName = entity.ContactName;
                s.ContactTitle = entity.ContactTitle;
                s.Address = entity.Address;
                s.City = entity.City;
                s.Region = entity.Region;
                s.PostalCode = entity.PostalCode;
                s.Country = entity.Country;
                s.Phone = entity.Phone;
                s.Fax = entity.Fax;
                s.HomePage = entity.HomePage;
                s.Products = entity.Products;

                _context.SaveChanges();

            }
            catch (Exception ex)
            {
                _context.Entry(s).State = EntityState.Unchanged;
                throw ex;
            }

        }
    }
}
