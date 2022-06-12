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

        public DataTable GetProductosSinStock()
        {
            DataTable products = ConvertirListaATabla(_productsData.GetProductosSinStock());
            products.Columns.Remove("Categories");
            products.Columns.Remove("Order_Details");
            products.Columns.Remove("Suppliers");

            return products;
        }

        public DataTable GetProductosConStock()
        {
            DataTable products = ConvertirListaATabla(_productsData.GetProductosConStock());
            products.Columns.Remove("Categories");
            products.Columns.Remove("Order_Details");
            products.Columns.Remove("Suppliers");

            return products;
        }

        public DataTable GetProducto789()
        {
            DataTable tbProduct = new DataTable();
            Products product = _productsData.GetProducto789();

            if (product != null)
            {
                tbProduct = ConvertirEntidadATabla(product);
                tbProduct.Columns.Remove("Categories");
                tbProduct.Columns.Remove("Order_Details");
                tbProduct.Columns.Remove("Suppliers");
            }
            else {
                tbProduct.Columns.Add(" ");
                tbProduct.Rows.Add("Sin resultados.");
            }

            return tbProduct;
        }

        public DataTable GetAllOrdenadosPorNombre()
        {
            DataTable tbProducts = new DataTable();
            List<Products> products = _productsData.GetAllOrdenadosPorNombre();

            if (products.Count > 0) {
                tbProducts = ConvertirListaATabla(products);
                tbProducts.Columns.Remove("Categories");
                tbProducts.Columns.Remove("Order_Details");
                tbProducts.Columns.Remove("Suppliers");
            }
            else
            {
                tbProducts.Columns.Add(" ");
                tbProducts.Rows.Add("Sin resultados.");
            }

            return tbProducts;
        }

        public DataTable GetAllOrdenadosPorUnitInStock()
        {
            DataTable tbProducts = new DataTable();
            List<Products> products = _productsData.GetAllOrdenadosPorUnitInStock();

            if (products.Count > 0)
            {
                tbProducts = ConvertirListaATabla(products);
                tbProducts.Columns.Remove("Categories");
                tbProducts.Columns.Remove("Order_Details");
                tbProducts.Columns.Remove("Suppliers");
            }
            else
            {
                tbProducts.Columns.Add(" ");
                tbProducts.Rows.Add("Sin resultados.");
            }

            return tbProducts;
        }

        public DataTable GetPrimerProduct()
        {
            DataTable tbProduct = new DataTable();
            Products product = _productsData.GetPrimerProduct();

            if (product != null)
            {
                tbProduct = ConvertirEntidadATabla(product);
                tbProduct.Columns.Remove("Categories");
                tbProduct.Columns.Remove("Order_Details");
                tbProduct.Columns.Remove("Suppliers");
            }
            else
            {
                tbProduct.Columns.Add(" ");
                tbProduct.Rows.Add("Sin resultados.");
            }

            return tbProduct;
        }

    }
}
