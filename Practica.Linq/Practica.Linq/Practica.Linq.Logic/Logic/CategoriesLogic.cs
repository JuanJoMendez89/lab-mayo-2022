using Practica.Linq.Entities.Entities;
using Practica.Linq.Logic.Interfaces;
using Practica.Linq.Data.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Reflection;

namespace Practica.Linq.Logic.Logic
{
    public class CategoriesLogic : BaseLogic<Categories>,  IABMLogic<Categories, int>
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

        public DataTable GetAll()
        {


            List<Categories> categories =  _categoriesData.GetAll();

            return ConvertirListaATabla(categories);
        }

        public DataTable GetByID(int id)
        {
            return ConvertirEntidadATabla(_categoriesData.GetByID(id));
        }

        public void Update(Categories entity)
        {
            _categoriesData.Update(entity);
        }

    }
}
