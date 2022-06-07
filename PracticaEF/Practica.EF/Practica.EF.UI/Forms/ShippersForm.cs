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
    public partial class ShippersForm : BaseForm
    {
        public ShippersForm(Main main)
        {
            InitializeComponent();

            _main = main;
        }

        protected void LoadGrid()
        {
            throw new NotImplementedException();
        }

        private void ShippersForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _main.Visible = true;
        }
    }
}
