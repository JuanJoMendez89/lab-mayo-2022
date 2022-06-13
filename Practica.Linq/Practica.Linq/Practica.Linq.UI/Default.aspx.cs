using Practica.Linq.Entities.Entities;
using Practica.Linq.Logic.Logic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practica.Linq.UI
{
    public partial class _Default : Page
    {
        private static string keyDataGridSource = "DataGridSource";
        protected void Page_Load(object sender, EventArgs e)
        {
            RegistrarScripts();
        }

        private void RegistrarScripts() {
            if (!Page.ClientScript.IsClientScriptIncludeRegistered("default-js")) {
                Page.ClientScript.RegisterClientScriptInclude(typeof(MasterPage),"default-js", "/Scripts/Default.js");
            }
        }

        private void CargarGrilla(DataTable source = null) {
            DataTable resultado = (source != null) ? source : Session[keyDataGridSource] as DataTable;

            dgvResultado.DataSource = resultado;
            dgvResultado.DataBind();
        }

        #region BUTTONS CONSIGNAS
        protected void BtnConsigna1_Click(object sender, EventArgs e)
        {
            CustomersLogic cl = new CustomersLogic();
            string id = val.Value;

            DataTable customer = cl.GetByID(id);

            Descripcion.InnerText = HttpContext.GetGlobalResourceObject("Concepts", "Consigna1").ToString();

            CargarGrilla(customer);
        }

        protected void BtnConsigna2_Click(object sender, EventArgs e)
        {
            ProductsLogic pl = new ProductsLogic();

            DataTable products = pl.GetProductosSinStock();

            Descripcion.InnerText = HttpContext.GetGlobalResourceObject("Concepts", "Consigna2").ToString();

            CargarGrilla(products);
        }

        protected void BtnConsigna3_Click(object sender, EventArgs e)
        {
            ProductsLogic pl = new ProductsLogic();

            DataTable products = pl.GetProductosConStock();

            Descripcion.InnerText = HttpContext.GetGlobalResourceObject("Concepts", "Consigna3").ToString();

            CargarGrilla(products);
        }

        protected void BtnConsigna4_Click(object sender, EventArgs e)
        {
            CustomersLogic cl = new CustomersLogic();

            DataTable customer = cl.GetByRegionWa();

            Descripcion.InnerText = HttpContext.GetGlobalResourceObject("Concepts", "Consigna4").ToString();

            CargarGrilla(customer);
        }

        protected void BtnConsigna5_Click(object sender, EventArgs e)
        {
            ProductsLogic pl = new ProductsLogic();

            DataTable products = pl.GetProducto789();

            Descripcion.InnerText = HttpContext.GetGlobalResourceObject("Concepts", "Consigna5").ToString();

            CargarGrilla(products);
        }

        protected void BtnConsigna6_Click(object sender, EventArgs e)
        {
            CustomersLogic cl = new CustomersLogic();

            DataTable customer = cl.GetNombres();

            Descripcion.InnerText = HttpContext.GetGlobalResourceObject("Concepts", "Consigna6").ToString();

            CargarGrilla(customer);
        }

        protected void BtnConsigna7_Click(object sender, EventArgs e)
        {
            CustomersLogic cl = new CustomersLogic();

            DataTable customer = cl.GetCustomerByFechaOrder();

            Descripcion.InnerText = HttpContext.GetGlobalResourceObject("Concepts", "Consigna7").ToString();

            CargarGrilla(customer);
        }
        #endregion

        #region BUTTONS CONSIGNAS OPCIONALES
        protected void BtnConsigna8_Click(object sender, EventArgs e)
        {
            CustomersLogic cl = new CustomersLogic();

            DataTable customer = cl.GetByPrimerosRegionWa();

            Descripcion.InnerText = HttpContext.GetGlobalResourceObject("Concepts", "Consigna8").ToString();

            CargarGrilla(customer);
        }

        protected void BtnConsigna9_Click(object sender, EventArgs e)
        {
            ProductsLogic pl = new ProductsLogic();

            DataTable products = pl.GetAllOrdenadosPorNombre();

            Descripcion.InnerText = HttpContext.GetGlobalResourceObject("Concepts", "Consigna9").ToString();

            CargarGrilla(products);
        }

        protected void BtnConsigna10_Click(object sender, EventArgs e)
        {
            ProductsLogic pl = new ProductsLogic();

            DataTable products = pl.GetAllOrdenadosPorUnitInStock();

            Descripcion.InnerText = HttpContext.GetGlobalResourceObject("Concepts", "Consigna10").ToString();

            CargarGrilla(products);
        }

        protected void BtnConsigna11_Click(object sender, EventArgs e)
        {
            CategoriesLogic cl = new CategoriesLogic();
            
            DataTable categories = cl.GetCategoriesConProducts();

            Descripcion.InnerText = HttpContext.GetGlobalResourceObject("Concepts", "Consigna11").ToString();

            CargarGrilla(categories);
        }

        protected void BtnConsigna12_Click(object sender, EventArgs e)
        {
            ProductsLogic pl = new ProductsLogic();

            DataTable products = pl.GetPrimerProduct();

            Descripcion.InnerText = HttpContext.GetGlobalResourceObject("Concepts", "Consigna12").ToString();

            CargarGrilla(products);
        }

        protected void BtnConsigna13_Click(object sender, EventArgs e)
        {
            CustomersLogic cl = new CustomersLogic();

            DataTable customers = cl.GetCustomerConOrdenesAsociadas();

            Descripcion.InnerText = HttpContext.GetGlobalResourceObject("Concepts", "Consigna13").ToString();

            CargarGrilla(customers);
        }
        #endregion

    }
}