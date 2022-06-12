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

            CargarGrilla(customer);
        }

        protected void BtnConsigna2_Click(object sender, EventArgs e)
        {
            ProductsLogic pl = new ProductsLogic();

            DataTable products = pl.GetProductosSinStock();

            CargarGrilla(products);
        }

        protected void BtnConsigna3_Click(object sender, EventArgs e)
        {
            ProductsLogic pl = new ProductsLogic();

            DataTable products = pl.GetProductosConStock();

            CargarGrilla(products);
        }

        protected void BtnConsigna4_Click(object sender, EventArgs e)
        {
            CustomersLogic cl = new CustomersLogic();

            DataTable customer = cl.GetByRegionWa();

            CargarGrilla(customer);
        }

        protected void BtnConsigna5_Click(object sender, EventArgs e)
        {
            ProductsLogic pl = new ProductsLogic();

            DataTable products = pl.GetProducto789();

            CargarGrilla(products);
        }

        protected void BtnConsigna6_Click(object sender, EventArgs e)
        {
            CustomersLogic cl = new CustomersLogic();

            DataTable customer = cl.GetNombres();

            CargarGrilla(customer);
        }

        protected void BtnConsigna7_Click(object sender, EventArgs e)
        {
            CustomersLogic cl = new CustomersLogic();

            DataTable customer = cl.GetCustomerByFechaOrder();

            CargarGrilla(customer);
        }
        #endregion

        #region BUTTONS CONSIGNAS OPCIONALES
        protected void BtnConsigna8_Click(object sender, EventArgs e)
        {
            CustomersLogic cl = new CustomersLogic();

            DataTable customer = cl.GetByPrimerosRegionWa();

            CargarGrilla(customer);
        }

        protected void BtnConsigna9_Click(object sender, EventArgs e)
        {
            ProductsLogic pl = new ProductsLogic();

            DataTable products = pl.GetAllOrdenadosPorNombre();

            CargarGrilla(products);
        }

        protected void BtnConsigna10_Click(object sender, EventArgs e)
        {
            ProductsLogic pl = new ProductsLogic();

            DataTable products = pl.GetAllOrdenadosPorUnitInStock();

            CargarGrilla(products);
        }

        protected void BtnConsigna11_Click(object sender, EventArgs e)
        {
            CategoriesLogic cl = new CategoriesLogic();
            DataTable categories = cl.GetCategoriesConProducts();

            CargarGrilla(categories);
        }

        protected void BtnConsigna12_Click(object sender, EventArgs e)
        {
            ProductsLogic pl = new ProductsLogic();

            DataTable products = pl.GetPrimerProduct();

            CargarGrilla(products);
        }

        protected void BtnConsigna13_Click(object sender, EventArgs e)
        {
            CustomersLogic cl = new CustomersLogic();

            DataTable customers = cl.GetCustomerConOrdenesAsociadas();

            CargarGrilla(customers);
        }
        #endregion

    }
}