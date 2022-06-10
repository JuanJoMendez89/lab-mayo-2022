using Practica.Linq.Data.Interfaces;
using Practica.Linq.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Linq.Data.Data
{
    class RegionData : BaseData, IAMBData<Region, int>
    {
        public void Add(Region entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Region> GetAll()
        {
            throw new NotImplementedException();
        }

        public Region GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Region entity)
        {
            throw new NotImplementedException();
        }
    }
}
