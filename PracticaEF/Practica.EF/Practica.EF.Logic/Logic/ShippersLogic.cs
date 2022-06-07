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
            _context.Shippers.Add(entity);

            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            Shippers shipper = _context.Shippers.Find(id);

            _context.Shippers.Remove(shipper);

            _context.SaveChanges();
        }

        public List<Shippers> GetAll()
        {
            return _context.Shippers.ToList();
        }

        public void Update(Shippers entity)
        {
            Shippers shipper = _context.Shippers.Find(entity.ShipperID);

            shipper.CompanyName = entity.CompanyName;
            shipper.Phone = entity.Phone;

            _context.SaveChanges();
        }
    }
}
