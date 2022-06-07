using Practica.EF.Entities.Entities;
using Practica.EF.Logic;
using Practica.EF.Logic.Logic;
using Practica.EF.UI.Modals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica.EF.UI.Forms
{
    public partial class CustomersForm : BaseForm
    {
        private CustomersLogic _customersLogic;

        public CustomersForm(Main main)
        {
            InitializeComponent();

            _main = main;
            _customersLogic = new CustomersLogic();
        }

        private void CustomersForm_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        protected void LoadGrid()
        {
            List<Customers> customers = _customersLogic.GetAll();

            dgvGrid.DataSource = customers;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CustomersEditor editor = new CustomersEditor(this);

            editor.Show();

            this.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Customers customer = new Customers();
            CustomersEditor editor = new CustomersEditor(this, customer, true);

            editor.Show();

            this.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void CustomersForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _main.Visible = true;
        }

    }
}
