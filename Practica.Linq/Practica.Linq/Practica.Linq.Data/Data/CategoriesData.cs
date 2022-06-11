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
    public class CategoriesData : BaseData, IAMBData<Categories, int>
    {
        public void Add(Categories entity)
        {
            try
            {
                if (_context.Categories.Any(c => c.CategoryID == entity.CategoryID))
                    throw new KeyDuplicadaException("Error de insercion, clave duplicada.", entity.CategoryID.ToString());

                _context.Categories.Add(entity);

                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        public void Delete(int id)
        {
            Categories c = _context.Categories.Find(id);

            try
            {
                _context.Categories.Remove(c);

                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                _context.Entry(c).State = EntityState.Unchanged;
                throw ex;
            }

        }

        public List<Categories> GetAll()
        {
            return _context.Categories.ToList();
        }

        public Categories GetByID(int id)
        {
            return _context.Categories.Find(id);
        }

        public void Update(Categories entity)
        {
            Categories c = _context.Categories.Find(entity.CategoryID);

            try
            {
                c.CategoryName = entity.CategoryName;
                c.Description = entity.Description;
                c.Picture = entity.Picture;
                c.Products = entity.Products;

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
