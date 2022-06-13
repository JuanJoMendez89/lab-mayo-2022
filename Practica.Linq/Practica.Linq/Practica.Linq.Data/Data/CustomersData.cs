﻿using Practica.Linq.Common.Exceptions;
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
    public class CustomersData : BaseData,  IAMBData<Customers, string>
    {
        public void Add(Customers entity)
        {
            {
                try
                {
                    if (_context.Customers.Any(c => c.CustomerID == entity.CustomerID))
                        throw new KeyDuplicadaException("Error de insercion, clave duplicada.", entity.CustomerID.ToString());

                    _context.Customers.Add(entity);

                    _context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public void Delete(string id)
        {
            Customers c = _context.Customers.Find(id);

            try
            {
                _context.Customers.Remove(c);

                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                _context.Entry(c).State = EntityState.Unchanged;
                throw ex;
            }
        }

        public List<Customers> GetAll()
        {
            return _context.Customers.ToList();
        }

        public Customers GetByID(string id)
        {
            return _context.Customers.Find(id);
        }

        public void Update(Customers entity)
        {
            Customers c = _context.Customers.Find(entity.CustomerID);

            try
            {
                c.CompanyName = entity.CompanyName;
                c.ContactName = entity.ContactName;
                c.ContactTitle = entity.ContactTitle;
                c.Address = entity.Address;
                c.City = entity.City;
                c.Region = entity.Region;
                c.PostalCode = entity.PostalCode;
                c.Country = entity.Country;
                c.Phone = entity.Phone;
                c.Fax = entity.Fax;
                c.Orders = entity.Orders;
                c.CustomerDemographics = entity.CustomerDemographics;

                _context.SaveChanges();

            }
            catch (Exception ex)
            {
                _context.Entry(c).State = EntityState.Unchanged;
                throw ex;
            }
        }

        public List<Customers> GetByRegionWa()
        {
           List<Customers> customers = (from c in _context.Customers
                        where c.Region == "WA"
                        select c).ToList();

            return customers;
        }

        public List<object> GetNombres() {
            List<object> list = new List<object>();

            var customers = (from c in _context.Customers
                             select new
                             {
                                 ContactNameUpperCase = c.ContactName.ToUpper(),
                                 ContactNameLowerCase = c.ContactName.ToLower(),
                             }).ToList();

            list.AddRange(customers);

            return list;
        }

        public List<object> GetCustomerByFechaOrder()
        {
            List<object> list = new List<object>();

            var customers = (from c in _context.Customers
                             join o in _context.Orders on c.CustomerID equals o.CustomerID
                             where o.OrderDate > new DateTime(1997,1,1) && c.Region == "WA"
                             select new
                             {
                                 ContactName = c.ContactName,
                                 OrderDate = o.OrderDate,
                             }).ToList();

            list.AddRange(customers);

            return list;
        }

        public List<Customers> GetByPrimerosRegionWa()
        {
            return _context.Customers.Where(c => c.Region == "WA").Take(3).ToList();
        }

        public List<object> GetCustomerConOrdenesAsociadas()
        {
            List<object> list = new List<object>();

            var query = (from c in _context.Customers
                         select new
                         {
                             ContactName = c.ContactName,
                             Orders = c.Orders.Count,
                         }).ToList();

            list.AddRange(query);

            return list;
        }

    }
}
