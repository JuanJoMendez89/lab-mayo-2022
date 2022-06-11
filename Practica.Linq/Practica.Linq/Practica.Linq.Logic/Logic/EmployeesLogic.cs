using Practica.Linq.Data.Data;
using Practica.Linq.Entities.Entities;
using Practica.Linq.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Linq.Logic.Logic
{
    public class EmployeesLogic : IABMLogic<Employees, int>
    {
        private readonly EmployeesData _employeesData;

        public EmployeesLogic()
        {
            _employeesData = new EmployeesData();
        }

        public void Add(Employees entity)
        {
            _employeesData.Add(entity);
        }

        public void Delete(int id)
        {
            _employeesData.Delete(id);
        }

        public List<Employees> GetAll()
        {
            return _employeesData.GetAll();
        }

        public Employees GetByID(int id)
        {
            return _employeesData.GetByID(id);
        }

        public void Update(Employees entity)
        {
            _employeesData.Update(entity);
        }
    }
}
