using Practica.EF.Entities.Entities;
using Practica.EF.Logic.Interfaces;
using System;
using System.Collections.Generic;
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

                throw ex.GetBaseException();
            }

        }

        public void Delete(string id)
        {
            try
            {
                Shippers shipper = _context.Shippers.Find(Convert.ToInt32(id));

                _context.Shippers.Remove(shipper);

                _context.SaveChanges();
            }
            catch (Exception ex)
            {

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

        public void Update(Shippers entity)
        {
            try
            {
                Shippers shipper = _context.Shippers.Find(entity.ShipperID);

                shipper.CompanyName = entity.CompanyName;
                shipper.Phone = entity.Phone;

                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex.GetBaseException();
            }

        }
    }
}
