using Practica.Linq.Data.Interfaces;
using Practica.Linq.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Linq.Data.Data
{
    class ProductsData : BaseData, IAMBData<Products, int>
    {
        public void Add(Products entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Products> GetAll()
        {
            throw new NotImplementedException();
        }

        public Products GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Products entity)
        {
            throw new NotImplementedException();
        }
    }
}
