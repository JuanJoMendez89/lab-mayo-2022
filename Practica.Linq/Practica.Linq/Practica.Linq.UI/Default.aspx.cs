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
            GetEvent();
            RegistrarScripts();
        }

        private void RegistrarScripts() {
            if (!Page.ClientScript.IsClientScriptIncludeRegistered("default-js")) {
                Page.ClientScript.RegisterClientScriptInclude("default-js", "/Scripts/Default.js");
            }
        }

        private void GetEvent() {
            if (Request["__EVENTTARGET"] == "btnConsigna1" && Request["__EVENTARGUMENT"] == "")
            {
                CargarGrilla();
            }
        }

        private void CargarGrilla(DataTable source = null) {
            DataTable resultado = (source != null) ? source : Session[keyDataGridSource] as DataTable;

            dgvResultado.DataSource = resultado;
            dgvResultado.DataBind();
        }

        #region BUTTONS CONSIGNAS
        protected void btnConsigna1_Click(object sender, EventArgs e)
        {
            CustomersLogic cl = new CustomersLogic();
            string id = val.Value;

            DataTable customer = cl.GetByID(id);

            CargarGrilla(customer);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ProductsLogic pl = new ProductsLogic();

            DataTable products = pl.RecuperarProductosSinStock();

            CargarGrilla(products);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {

        }

        protected void Button4_Click(object sender, EventArgs e)
        {

        }

        protected void Button5_Click(object sender, EventArgs e)
        {

        }

        protected void Button6_Click(object sender, EventArgs e)
        {

        }

        protected void Button7_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region BUTTONS CONSIGNAS OPCIONALES
        protected void Button8_Click(object sender, EventArgs e)
        {

        }

        protected void Button9_Click(object sender, EventArgs e)
        {

        }

        protected void Button10_Click(object sender, EventArgs e)
        {

        }

        protected void Button11_Click(object sender, EventArgs e)
        {

        }

        protected void Button12_Click(object sender, EventArgs e)
        {

        }

        protected void Button13_Click(object sender, EventArgs e)
        {

        }
        #endregion

    }
}