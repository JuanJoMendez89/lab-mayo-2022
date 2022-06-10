using Practica.Linq.Data.Interfaces;
using Practica.Linq.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Linq.Data.Data
{
    class CustomerDemographicsData : BaseData, IAMBData<CustomerDemographics, string>
    {
        public void Add(CustomerDemographics entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<CustomerDemographics> GetAll()
        {
            throw new NotImplementedException();
        }

        public CustomerDemographics GetByID(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(CustomerDemographics entity)
        {
            throw new NotImplementedException();
        }
    }
}
