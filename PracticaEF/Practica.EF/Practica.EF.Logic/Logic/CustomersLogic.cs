using Practica.EF.Entities.Entities;
using Practica.EF.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.EF.Logic.Logic
{
    public class CustomersLogic : BaseLogic, IABMLogic<Customers>
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
                throw ex.GetBaseException();
            }

        }

        public void Delete(string id)
        {
            try
            {
                Customers customer = _context.Customers.Find(id);

                _context.Customers.Remove(customer);

                _context.SaveChanges();
            }
            catch (Exception ex)
            {
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

        public void Update(Customers entity)
        {
            try
            {
                Customers customers = _context.Customers.Find(entity.CustomerID);

                customers.CompanyName = entity.CompanyName;
                customers.ContactName = entity.ContactName;
                customers.ContactTitle = entity.ContactTitle;
                customers.Address = entity.Address;
                customers.City = entity.City;
                customers.Region = entity.Region;
                customers.PostalCode = entity.PostalCode;
                customers.Country = entity.Country;
                customers.Phone = entity.Phone;
                customers.Fax = entity.Fax;

                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex.GetBaseException();
            }

        }
    }
}
