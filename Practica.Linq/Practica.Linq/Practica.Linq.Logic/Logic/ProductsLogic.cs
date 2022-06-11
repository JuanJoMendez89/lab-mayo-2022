using Practica.Linq.Data.Data;
using Practica.Linq.Entities.Entities;
using Practica.Linq.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Linq.Logic.Logic
{
    public class ProductsLogic : BaseLogic<Products>, IABMLogic<Products, int>
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

        public DataTable GetAll()
        {
            return ConvertirListaATabla(_productsData.GetAll());
        }

        public DataTable GetByID(int id)
        {
            return ConvertirEntidadATabla(_productsData.GetByID(id));
        }

        public void Update(Products entity)
        {
            _productsData.Update(entity);
        }

        public DataTable RecuperarProductosSinStock()
        {
            DataTable products = ConvertirListaATabla(_productsData.RecuperarProductosSinStock());
            products.Columns.Remove("Categories");
            products.Columns.Remove("Order_Details");
            products.Columns.Remove("Suppliers");

            return products;
        }

    }
}
