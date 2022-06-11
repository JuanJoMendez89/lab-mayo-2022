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
    public class CustomerDemographicsData : BaseData, IAMBData<CustomerDemographics, string>
    {
        public void Add(CustomerDemographics entity)
        {
            try
            {
                if (_context.CustomerDemographics.Any(c => c.CustomerTypeID == entity.CustomerTypeID))
                    throw new KeyDuplicadaException("Error de insercion, clave duplicada.", entity.CustomerTypeID.ToString());

                _context.CustomerDemographics.Add(entity);

                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(string id)
        {
            CustomerDemographics c = _context.CustomerDemographics.Find(id);

            try
            {
                _context.CustomerDemographics.Remove(c);

                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                _context.Entry(c).State = EntityState.Unchanged;
                throw ex;
            }
        }

        public List<CustomerDemographics> GetAll()
        {
            return _context.CustomerDemographics.ToList();
        }

        public CustomerDemographics GetByID(string id)
        {
            return _context.CustomerDemographics.Find(id);
        }

        public void Update(CustomerDemographics entity)
        {
            CustomerDemographics c = _context.CustomerDemographics.Find(entity.CustomerTypeID);

            try
            {
                c.CustomerDesc = entity.CustomerDesc;
                c.Customers = entity.Customers;

                _context.SaveChanges();

            }
            catch (Exception ex)
            {
                _context.Entry(c).State = EntityState.Unchanged;
                throw ex;
            }
        }
    }
}
