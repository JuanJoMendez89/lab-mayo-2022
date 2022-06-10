using Practica.Linq.Data.Interfaces;
using Practica.Linq.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Linq.Data.Data
{
    class SuppliersData : BaseData, IAMBData<Suppliers, int>
    {
        public void Add(Suppliers entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Suppliers> GetAll()
        {
            throw new NotImplementedException();
        }

        public Suppliers GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Suppliers entity)
        {
            throw new NotImplementedException();
        }
    }
}
