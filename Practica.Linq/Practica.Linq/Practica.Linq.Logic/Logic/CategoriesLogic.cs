using Practica.Linq.Entities.Entities;
using Practica.Linq.Logic.Interfaces;
using Practica.Linq.Data.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Linq.Logic.Logic
{
    public class CategoriesLogic : IABMLogic<Categories, int>
    {
        private readonly CategoriesData _categoriesData;

        public CategoriesLogic()
        {
            _categoriesData = new CategoriesData();
        }
        public void Add(Categories entity)
        {
            _categoriesData.Add(entity);
        }

        public void Delete(int id)
        {
            _categoriesData.Delete(id);
        }

        public List<Categories> GetAll()
        {
            return _categoriesData.GetAll();
        }

        public Categories GetByID(int id)
        {
            return _categoriesData.GetByID(id);
        }

        public void Update(Categories entity)
        {
            _categoriesData.Update(entity);
        }
    }
}
