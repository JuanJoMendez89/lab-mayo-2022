using Practica.Linq.Data.Data;
using Practica.Linq.Entities.Entities;
using Practica.Linq.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Linq.Logic.Logic
{
    public class EmployeesLogic : BaseLogic<Employees, int>
    {
        private readonly EmployeesData _employeesData;

        public EmployeesLogic()
        {
            _employeesData = new EmployeesData();
        }

        public override void Add(Employees entity)
        {
            _employeesData.Add(entity);
        }

        public override void Delete(int id)
        {
            _employeesData.Delete(id);
        }

        public override DataTable GetAll()
        {
            return ConvertirListaATabla(_employeesData.GetAll());
        }

        public override DataTable GetByID(int id)
        {
            return ConvertirEntidadATabla(_employeesData.GetByID(id));
        }

        public override void Update(Employees entity)
        {
            _employeesData.Update(entity);
        }
    }
}
