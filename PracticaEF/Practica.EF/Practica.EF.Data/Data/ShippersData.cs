using Practica.EF.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.EF.Data.Data
{
    public class ShippersData : BaseData<Shippers, int>
    {
        public override void Add(Shippers entity)
        {
            try
            {
                _context.Shippers.Add(entity);

                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                _context.Entry(entity).State = EntityState.Detached;
                throw ex.GetBaseException();
            }

        }

        public override void Delete(int id)
        {
            Shippers shipper = _context.Shippers.Find(id);

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

        public override List<Shippers> GetAll()
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

        public override Shippers GetByID(int id)
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

        public override void Update(Shippers entity)
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
