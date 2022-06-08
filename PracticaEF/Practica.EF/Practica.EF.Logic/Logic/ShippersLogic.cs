using Practica.EF.Entities.Entities;
using Practica.EF.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.EF.Logic.Logic
{
    public class ShippersLogic : BaseLogic, IABMLogic<Shippers>
    {
        public void Add(Shippers entity)
        {
            try
            {
                _context.Shippers.Add(entity);

                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                _context.Entry(entity).State = EntityState.Unchanged;
                throw ex.GetBaseException();
            }

        }

        public void Delete(string id)
        {
            Shippers shipper = _context.Shippers.Find(Convert.ToInt32(id));

            try
            {
                _context.Shippers.Remove(shipper);

                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                _context.Entry(shipper).State = EntityState.Unchanged;
                throw ex.GetBaseException();
            }

        }

        public List<Shippers> GetAll()
        {
            try
            {
                return _context.Shippers.ToList();
            }
            catch (Exception ex)
            {

                throw ex.GetBaseException();
            }

        }

        public Shippers GetByID(string id)
        {
            try
            {
                return _context.Shippers.Find(Convert.ToInt32(id));
            }
            catch (Exception ex)
            {

                throw ex.GetBaseException();
            }
        }

        public void Update(Shippers entity)
        {
            Shippers shipper = _context.Shippers.Find(entity.ShipperID);

            try
            {
                shipper.CompanyName = entity.CompanyName;
                shipper.Phone = entity.Phone;

                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                _context.Entry(shipper).State = EntityState.Unchanged;
                throw ex.GetBaseException();
            }

        }
    }
}
