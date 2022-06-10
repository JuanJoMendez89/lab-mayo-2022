using Practica.Linq.Data.Interfaces;
using Practica.Linq.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Linq.Data.Data
{
    class CustomersData : BaseData,  IAMBData<Customers, string>
    {
        public void Add(Customers entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<Customers> GetAll()
        {
            throw new NotImplementedException();
        }

        public Customers GetByID(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(Customers entity)
        {
            throw new NotImplementedException();
        }
    }
}
