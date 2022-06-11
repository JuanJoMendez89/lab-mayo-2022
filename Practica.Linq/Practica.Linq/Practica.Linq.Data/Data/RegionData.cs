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
    public class RegionData : BaseData, IAMBData<Region, int>
    {
        public void Add(Region entity)
        {
            try
            {
                if (_context.Region.Any(c => c.RegionID == entity.RegionID))
                    throw new KeyDuplicadaException("Error de insercion, clave duplicada.", entity.RegionID.ToString());

                _context.Region.Add(entity);

                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(int id)
        {
            Region r= _context.Region.Find(id);

            try
            {
                _context.Region.Remove(r);

                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                _context.Entry(r).State = EntityState.Unchanged;
                throw ex;
            }
        }

        public List<Region> GetAll()
        {
            return _context.Region.ToList();
        }

        public Region GetByID(int id)
        {
            return _context.Region.Find(id);
        }

        public void Update(Region entity)
        {
            Region r = _context.Region.Find(entity.RegionID);

            try
            {
                r.RegionDescription = entity.RegionDescription;
                r.Territories = entity.Territories;

                _context.SaveChanges();

            }
            catch (Exception ex)
            {
                _context.Entry(r).State = EntityState.Unchanged;
                throw ex;
            }

        }
    }
}
