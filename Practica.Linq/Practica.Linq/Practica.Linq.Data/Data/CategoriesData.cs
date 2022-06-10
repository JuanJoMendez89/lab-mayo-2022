using Practica.Linq.Data.Interfaces;
using Practica.Linq.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Linq.Data.Data
{
    class CategoriesData : BaseData, IAMBData<Categories, int>
    {
        public void Add(Categories entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Categories> GetAll()
        {
            throw new NotImplementedException();
        }

        public Categories GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Categories entity)
        {
            throw new NotImplementedException();
        }
    }
}
