using Practica.Linq.Data.Interfaces;
using Practica.Linq.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Linq.Data.Data
{
    class TerritoriesData : BaseData, IAMBData<Territories, string>
    {
        public void Add(Territories entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<Territories> GetAll()
        {
            throw new NotImplementedException();
        }

        public Territories GetByID(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(Territories entity)
        {
            throw new NotImplementedException();
        }
    }
}
