using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaLayer;

namespace PresentacionLayer.Forms
{
    public partial class PuntoCuatro : Form
    {
        private Main _main;

        public PuntoCuatro(Main main)
        {
            InitializeComponent();

            this._main = main;
        }

        private void btnDispararExcepcion_Click(object sender, EventArgs e)
        {
            try
            {
                Logic.DispararExcepcionPersonalizada();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
        }

        private void PuntoCuatro_FormClosed(object sender, FormClosedEventArgs e)
        {
            this._main.Visible = true;
        }
    }
}
