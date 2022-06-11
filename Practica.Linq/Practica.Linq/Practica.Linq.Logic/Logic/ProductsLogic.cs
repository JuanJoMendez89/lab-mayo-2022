using Practica.Linq.Data.Data;
using Practica.Linq.Entities.Entities;
using Practica.Linq.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Linq.Logic.Logic
{
    public class ProductsLogic : IABMLogic<Products, int>
    {
        private readonly ProductsData _productsData;

        public ProductsLogic()
        {
            _productsData = new ProductsData();
        }

        public void Add(Products entity)
        {
            _productsData.Add(entity);
        }

        public void Delete(int id)
        {
            _productsData.Delete(id);
        }

        public List<Products> GetAll()
        {
            return _productsData.GetAll();
        }

        public Products GetByID(int id)
        {
            return _productsData.GetByID(id);
        }

        public void Update(Products entity)
        {
            _productsData.Update(entity);
        }
    }
}
