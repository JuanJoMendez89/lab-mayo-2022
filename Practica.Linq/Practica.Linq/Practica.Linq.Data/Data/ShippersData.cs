using Practica.Linq.Data.Interfaces;
using Practica.Linq.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Linq.Data.Data
{
    class ShippersData : BaseData, IAMBData<Shippers, int>
    {
        public void Add(Shippers entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Shippers> GetAll()
        {
            throw new NotImplementedException();
        }

        public Shippers GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Shippers entity)
        {
            throw new NotImplementedException();
        }
    }
}
