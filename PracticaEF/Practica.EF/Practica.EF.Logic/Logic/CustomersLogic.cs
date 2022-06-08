using Practica.EF.Entities.Entities;
using Practica.EF.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;

namespace Practica.EF.Logic.Logic
{
    public class CustomersLogic : BaseLogic, ICRUDLogic<Customers, string>
    {
        public void Add(Customers entity)
        {
            try
            {
                _context.Customers.Add(entity);

                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                _context.Entry(entity).State = EntityState.Detached;
                throw ex.GetBaseException();
            }

        }

        public void Delete(string id)
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

        public List<Customers> GetAll()
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

        public Customers GetByID(string id)
        {
            return _context.Customers.Find(id);
        }

        public void Update(Customers entity)
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
