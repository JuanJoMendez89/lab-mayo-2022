using Practica.Linq.Data.Interfaces;
using Practica.Linq.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Linq.Data.Data
{
    class OrdersData : BaseData, IAMBData<Orders, int>
    {
        public void Add(Orders entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Orders> GetAll()
        {
            throw new NotImplementedException();
        }

        public Orders GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Orders entity)
        {
            throw new NotImplementedException();
        }
    }
}
