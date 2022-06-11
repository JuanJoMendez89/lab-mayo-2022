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
    public class EmployeesData : BaseData, IAMBData<Employees, int>
    {
        public void Add(Employees entity)
        {
            {
                try
                {
                    if (_context.Employees.Any(c => c.EmployeeID == entity.EmployeeID))
                        throw new KeyDuplicadaException("Error de insercion, clave duplicada.", entity.EmployeeID.ToString());

                    _context.Employees.Add(entity);

                    _context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public void Delete(int id)
        {
            Employees e = _context.Employees.Find(id);

            try
            {
                _context.Employees.Remove(e);

                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                _context.Entry(e).State = EntityState.Unchanged;
                throw ex;
            }
        }

        public List<Employees> GetAll()
        {
            return _context.Employees.ToList();
        }

        public Employees GetByID(int id)
        {
            return _context.Employees.Find(id);
        }

        public void Update(Employees entity)
        {
            Employees e = _context.Employees.Find(entity.EmployeeID);

            try
            {
                e.LastName = entity.LastName;
                e.FirstName = entity.FirstName;
                e.Title = entity.Title;
                e.TitleOfCourtesy = entity.TitleOfCourtesy;
                e.BirthDate = entity.BirthDate;
                e.HireDate = entity.HireDate;
                e.Address = entity.Address;
                e.City = entity.City;
                e.Region = entity.Region;
                e.PostalCode = entity.PostalCode;
                e.Orders = entity.Orders;
                e.Country = entity.Country;
                e.HomePhone = entity.HomePhone;
                e.Extension = entity.Extension;
                e.Photo = entity.Photo;
                e.Notes = entity.Notes;
                e.ReportsTo = entity.ReportsTo;
                e.PhotoPath = entity.PhotoPath;
                e.Employees1 = entity.Employees1;
                e.Employees2 = entity.Employees2;
                e.Orders = entity.Orders;
                e.Territories = entity.Territories;

                _context.SaveChanges();

            }
            catch (Exception ex)
            {
                _context.Entry(e).State = EntityState.Unchanged;
                throw ex;
            }
        }

    }
}
