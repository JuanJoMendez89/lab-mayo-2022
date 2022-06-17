using Practica.EF.Common.Exceptions;
using Practica.EF.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.EF.Data.Data
{
    public class CustomersData : BaseData<Customers, string>
    {
        public override void Add(Customers entity)
        {
            try
            {
                if (_context.Customers.Any(c => c.CustomerID == entity.CustomerID))
                {
                    throw new DuplicateKeyException("Can't insert duplicate key.", entity.CustomerID);
                }

                _context.Customers.Add(entity);

                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex.GetBaseException();
            }

        }

        public override void Delete(string id)
        {
            Customers customer = _context.Customers.Find(id);

            try
            {
                _context.Customers.Remove(customer);

                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                _context.Entry(customer).State = EntityState.Unchanged;
                throw ex.GetBaseException();
            }

        }

        public override List<Customers> GetAll()
        {
            try
            {
                return _context.Customers.ToList();
            }
            catch (Exception ex)
            {
                throw ex.GetBaseException();
            }

        }

        public override Customers GetByID(string id)
        {
            return _context.Customers.Find(id);
        }

        public override void Update(Customers entity)
        {
            Customers customer = _context.Customers.Find(entity.CustomerID);

            try
            {
                customer.CompanyName = entity.CompanyName;
                customer.ContactName = entity.ContactName;
                customer.ContactTitle = entity.ContactTitle;
                customer.Address = entity.Address;
                customer.City = entity.City;
                customer.Region = entity.Region;
                customer.PostalCode = entity.PostalCode;
                customer.Country = entity.Country;
                customer.Phone = entity.Phone;
                customer.Fax = entity.Fax;

                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                _context.Entry(customer).State = EntityState.Unchanged;
                throw ex.GetBaseException();
            }

        }
    }
}
