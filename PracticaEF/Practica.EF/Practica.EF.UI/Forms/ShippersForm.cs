using Practica.EF.Entities.Entities;
using Practica.EF.Logic.Logic;
using Practica.EF.UI.Modals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica.EF.UI.Forms
{
    public partial class ShippersForm : BaseForm
    {
        public ShippersForm(Main main)
        {
            InitializeComponent();

            _main = main;
        }

        private void ShippersForm_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        protected void LoadGrid()
        {
            try
            {
                List<Shippers> shippers = new ShippersLogic().GetAll();

                dgvGrid.DataSource = null;
                dgvGrid.Rows.Clear();

                dgvGrid.DataSource = shippers;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }

        private void ShippersForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _main.Visible = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ShippersEditor editor = new ShippersEditor();
            editor.FormClosed += Editor_FormClosed;

            editor.Show();

            this.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvGrid.SelectedRows[0];

            Shippers shipper = new Shippers
            {
                ShipperID = Convert.ToInt32(row.Cells["ShipperID"].Value),
                CompanyName = row.Cells["CompanyName"].Value.ToString(),
                Phone = (row.Cells["Phone"].Value ?? String.Empty).ToString(),
            };

            ShippersEditor editor = new ShippersEditor(shipper, true);
            editor.FormClosed += Editor_FormClosed;

            editor.Show();

            this.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dgvGrid.SelectedRows[0];
                string id = row.Cells["ShipperID"].Value.ToString();

                new ShippersLogic().Delete(id);

                LoadGrid();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Can't delete. There's orders binded to this shipper.", "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        void Editor_FormClosed(object sender, FormClosedEventArgs e)
        {
            bool isChangesSaved = Convert.ToBoolean(sender.GetType().GetProperty("IsChangesSaved").GetValue(sender));

            if (isChangesSaved)
            {
                LoadGrid();
            }

            this.Enabled = true;
        }
    }
}
