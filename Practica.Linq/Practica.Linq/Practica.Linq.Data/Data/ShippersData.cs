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
    public class ShippersData : BaseData, IAMBData<Shippers, int>
    {
        public void Add(Shippers entity)
        {
            try
            {
                if (_context.Shippers.Any(c => c.ShipperID == entity.ShipperID))
                    throw new KeyDuplicadaException("Error de insercion, clave duplicada.", entity.ShipperID.ToString());

                _context.Shippers.Add(entity);

                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(int id)
        {
            Shippers s = _context.Shippers.Find(id);

            try
            {
                _context.Shippers.Remove(s);

                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                _context.Entry(s).State = EntityState.Unchanged;
                throw ex;
            }
        }

        public List<Shippers> GetAll()
        {
            return _context.Shippers.ToList();
        }

        public Shippers GetByID(int id)
        {
            return _context.Shippers.Find(id);
        }

        public void Update(Shippers entity)
        {
            Shippers s = _context.Shippers.Find(entity.ShipperID);

            try
            {
                s.CompanyName = entity.CompanyName;
                s.Phone = entity.Phone;
                s.Orders = entity.Orders;

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
