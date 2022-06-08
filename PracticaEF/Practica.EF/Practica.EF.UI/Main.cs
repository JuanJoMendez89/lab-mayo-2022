using Practica.EF.UI.Forms;
using System;
using System.Windows.Forms;

namespace Practica.EF.UI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            CustomersForm customersform = new CustomersForm(this);

            customersform.Show();

            this.Visible = false;
        }

        private void btnShippers_Click(object sender, EventArgs e)
        {
            ShippersForm shippersForm = new ShippersForm(this);

            shippersForm.Show();

            this.Visible = false;
        }
    }
}
