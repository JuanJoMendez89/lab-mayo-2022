using Practica.EF.Entities.Entities;
using Practica.EF.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.EF.Logic.Logic
{
    public class CustomersLogic : BaseLogic, IABMLogic<Customers>
    {
        public void Add(Customers entity)
        {
            _context.Customers.Add(entity);

            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            Customers customer = _context.Customers.Find(id.ToString());

            _context.Customers.Remove(customer);

            _context.SaveChanges();
        }

        public List<Customers> GetAll()
        {
            return _context.Customers.ToList();
        }

        public void Update(Customers entity)
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
    }
}
