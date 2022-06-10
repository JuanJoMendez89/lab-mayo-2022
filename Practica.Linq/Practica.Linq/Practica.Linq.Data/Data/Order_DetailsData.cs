using Practica.Linq.Data.Interfaces;
using Practica.Linq.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Linq.Data.Data
{
    class Order_DetailsData : BaseData, IAMBData<Order_Details, int>
    {
        public void Add(Order_Details entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Order_Details> GetAll()
        {
            throw new NotImplementedException();
        }

        public Order_Details GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Order_Details entity)
        {
            throw new NotImplementedException();
        }
    }
}
