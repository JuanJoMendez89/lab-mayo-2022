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
    public class TerritoriesData : BaseData, IAMBData<Territories, string>
    {
        public void Add(Territories entity)
        {
            try
            {
                if (_context.Territories.Any(c => c.TerritoryID == entity.TerritoryID))
                    throw new KeyDuplicadaException("Error de insercion, clave duplicada.", entity.TerritoryID.ToString());

                _context.Territories.Add(entity);

                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(string id)
        {
            Territories t = _context.Territories.Find(id);

            try
            {
                _context.Territories.Remove(t);

                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                _context.Entry(t).State = EntityState.Unchanged;
                throw ex;
            }
        }

        public List<Territories> GetAll()
        {
            return _context.Territories.ToList();
        }

        public Territories GetByID(string id)
        {
            return _context.Territories.Find(id);
        }

        public void Update(Territories entity)
        {
            Territories t = _context.Territories.Find(entity.TerritoryID);

            try
            {
                t.TerritoryDescription = entity.TerritoryDescription;
                t.RegionID = entity.RegionID;
                t.Region = entity.Region;
                t.Employees = entity.Employees;
 
                _context.SaveChanges();

            }
            catch (Exception ex)
            {
                _context.Entry(t).State = EntityState.Unchanged;
                throw ex;
            }

        }
    }
}
