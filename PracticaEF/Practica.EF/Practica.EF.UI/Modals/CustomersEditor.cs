using Practica.EF.Entities.Entities;
using Practica.EF.UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica.EF.UI.Modals
{
    public partial class CustomersEditor : Form
    {
        private CustomersForm _customersForm;
        private Customers _customer;
        private readonly bool _isEdit = false;

        public CustomersEditor(CustomersForm customersForm)
        {
            InitializeComponent();

            _customersForm = customersForm;
        }

        public CustomersEditor(CustomersForm customersForm, Customers customer, bool isEdit)
        {
            InitializeComponent();

            _customersForm = customersForm;
            _customer = customer;

            _isEdit = isEdit;
        }

        private void CustomersEditor_FormClosed(object sender, FormClosedEventArgs e)
        {
            _customersForm.Enabled = true;
        }
    }
}
