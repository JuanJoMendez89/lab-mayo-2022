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
    public partial class ShippersEditor : Form
    {
        private ShippersForm _shippersForm;
        private Shippers _shipper;
        private bool _isEdit;

        public ShippersEditor(ShippersForm shippersForm)
        {
            InitializeComponent();

            _shippersForm = shippersForm;
        }

        public ShippersEditor(ShippersForm shippersForm, Shippers shipper, bool isEdit)
        {
            InitializeComponent();

            _shippersForm = shippersForm;
            _shipper = shipper;

            _isEdit = isEdit;
        }

        private void ShippersEditor_FormClosed(object sender, FormClosedEventArgs e)
        {
            _shippersForm.Enabled = true;
        }
    }
}
