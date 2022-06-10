using Practica.Linq.Data.Interfaces;
using Practica.Linq.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Linq.Data.Data
{
    class EmployeesData : BaseData, IAMBData<Employees, int>
    {
        public void Add(Employees entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Employees> GetAll()
        {
            throw new NotImplementedException();
        }

        public Employees GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Employees entity)
        {
            throw new NotImplementedException();
        }
    }
}
