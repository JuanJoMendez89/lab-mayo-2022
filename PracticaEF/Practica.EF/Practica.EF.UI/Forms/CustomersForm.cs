using Practica.EF.Entities.Entities;
using Practica.EF.Logic.Logic;
using Practica.EF.UI.Modals;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Practica.EF.UI.Forms
{
    public partial class CustomersForm : BaseForm
    {
        private CustomersLogic _customerLogic;
        public CustomersForm(Main main)
        {
            InitializeComponent();

            _main = main;

            _customerLogic = new CustomersLogic();
        }

        private void CustomersForm_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        protected void LoadGrid()
        {
            try
            {
                List<Customers> customers = _customerLogic.GetAll();

                dgvGrid.DataSource = null;
                dgvGrid.Rows.Clear();

                dgvGrid.DataSource = customers;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CustomersEditor editor = new CustomersEditor(_customerLogic);
            editor.FormClosed += Editor_FormClosed;

            editor.Show();

            this.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvGrid.SelectedRows[0];

            Customers customer = new Customers {
                CustomerID = row.Cells["CustomerID"].Value.ToString(),
                CompanyName = row.Cells["CompanyName"].Value.ToString(),
                ContactName = (row.Cells["ContactName"].Value ?? String.Empty).ToString(),
                ContactTitle = (row.Cells["ContactTitle"].Value ?? String.Empty).ToString(),
                Address = (row.Cells["Address"].Value ?? String.Empty).ToString(),
                City = (row.Cells["City"].Value ?? String.Empty).ToString(),
                Region = (row.Cells["Region"].Value ?? String.Empty).ToString(),
                Country = (row.Cells["Country"].Value ?? String.Empty).ToString(),
                PostalCode = (row.Cells["PostalCode"].Value ?? String.Empty).ToString(),
                Phone = (row.Cells["Phone"].Value ?? String.Empty).ToString(),
                Fax = (row.Cells["Fax"].Value ?? String.Empty).ToString(),
            };

            CustomersEditor editor = new CustomersEditor(customer, _customerLogic, true);
            editor.FormClosed += Editor_FormClosed;

            editor.Show();

            this.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dgvGrid.SelectedRows[0];
                string id = row.Cells["CustomerID"].Value.ToString();

                _customerLogic.Delete(id);

                LoadGrid();
            }
            catch (SqlException) {
                MessageBox.Show("Can't delete. There're orders bound to this customer.", "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }

        private void CustomersForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _main.Visible = true;
        }

        void Editor_FormClosed(object sender, FormClosedEventArgs e) {
            bool isChangesSaved = Convert.ToBoolean(sender.GetType().GetProperty("IsChangesSaved").GetValue(sender));

            if (isChangesSaved) {
                LoadGrid();
            }

            this.Enabled = true;
        }

    }
}
