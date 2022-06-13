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

            Descripcion.InnerText = $"Consigna 1: {HttpContext.GetGlobalResourceObject("Concepts", "Consigna1")}";

            CargarGrilla(customer);
        }

        protected void BtnConsigna2_Click(object sender, EventArgs e)
        {
            ProductsLogic pl = new ProductsLogic();

            DataTable products = pl.GetProductosSinStock();

            Descripcion.InnerText = $"Consigna 2: {HttpContext.GetGlobalResourceObject("Concepts", "Consigna2")}";

            CargarGrilla(products);
        }

        protected void BtnConsigna3_Click(object sender, EventArgs e)
        {
            ProductsLogic pl = new ProductsLogic();

            DataTable products = pl.GetProductosConStock();

            Descripcion.InnerText = $"Consigna 3: {HttpContext.GetGlobalResourceObject("Concepts", "Consigna3")}";

            CargarGrilla(products);
        }

        protected void BtnConsigna4_Click(object sender, EventArgs e)
        {
            CustomersLogic cl = new CustomersLogic();

            DataTable customer = cl.GetByRegionWa();

            Descripcion.InnerText = $"Consigna 4: {HttpContext.GetGlobalResourceObject("Concepts", "Consigna4")}";

            CargarGrilla(customer);
        }

        protected void BtnConsigna5_Click(object sender, EventArgs e)
        {
            ProductsLogic pl = new ProductsLogic();

            DataTable products = pl.GetProducto789();

            Descripcion.InnerText = $"Consigna 5: {HttpContext.GetGlobalResourceObject("Concepts", "Consigna5")}";

            CargarGrilla(products);
        }

        protected void BtnConsigna6_Click(object sender, EventArgs e)
        {
            CustomersLogic cl = new CustomersLogic();

            DataTable customer = cl.GetNombres();

            Descripcion.InnerText = $"Consigna 6: {HttpContext.GetGlobalResourceObject("Concepts", "Consigna6")}";

            CargarGrilla(customer);
        }

        protected void BtnConsigna7_Click(object sender, EventArgs e)
        {
            CustomersLogic cl = new CustomersLogic();

            DataTable customer = cl.GetCustomerByFechaOrder();

            Descripcion.InnerText = $"Consigna 7: {HttpContext.GetGlobalResourceObject("Concepts", "Consigna7")}";

            CargarGrilla(customer);
        }
        #endregion

        #region BUTTONS CONSIGNAS OPCIONALES
        protected void BtnConsigna8_Click(object sender, EventArgs e)
        {
            CustomersLogic cl = new CustomersLogic();

            DataTable customer = cl.GetByPrimerosRegionWa();

            Descripcion.InnerText = $"Consigna 8: {HttpContext.GetGlobalResourceObject("Concepts", "Consigna8")}";

            CargarGrilla(customer);
        }

        protected void BtnConsigna9_Click(object sender, EventArgs e)
        {
            ProductsLogic pl = new ProductsLogic();

            DataTable products = pl.GetAllOrdenadosPorNombre();

            Descripcion.InnerText = $"Consigna 9: {HttpContext.GetGlobalResourceObject("Concepts", "Consigna9")}";

            CargarGrilla(products);
        }

        protected void BtnConsigna10_Click(object sender, EventArgs e)
        {
            ProductsLogic pl = new ProductsLogic();

            DataTable products = pl.GetAllOrdenadosPorUnitInStock();

            Descripcion.InnerText = $"Consigna 10: {HttpContext.GetGlobalResourceObject("Concepts", "Consigna10")}";

            CargarGrilla(products);
        }

        protected void BtnConsigna11_Click(object sender, EventArgs e)
        {
            CategoriesLogic cl = new CategoriesLogic();
            
            DataTable categories = cl.GetCategoriesConProducts();

            Descripcion.InnerText = $"Consigna 11: {HttpContext.GetGlobalResourceObject("Concepts", "Consigna11")}";

            CargarGrilla(categories);
        }

        protected void BtnConsigna12_Click(object sender, EventArgs e)
        {
            ProductsLogic pl = new ProductsLogic();

            DataTable products = pl.GetPrimerProduct();

            Descripcion.InnerText = $"Consigna 12: {HttpContext.GetGlobalResourceObject("Concepts", "Consigna12")}";

            CargarGrilla(products);
        }

        protected void BtnConsigna13_Click(object sender, EventArgs e)
        {
            CustomersLogic cl = new CustomersLogic();

            DataTable customers = cl.GetCustomerConOrdenesAsociadas();

            Descripcion.InnerText = $"Consigna 13: {HttpContext.GetGlobalResourceObject("Concepts", "Consigna13")}";

            CargarGrilla(customers);
        }
        #endregion

    }
}