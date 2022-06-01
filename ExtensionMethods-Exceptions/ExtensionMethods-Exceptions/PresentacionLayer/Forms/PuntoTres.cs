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
    public partial class PuntoTres : Form
    {
        private Main _main;

        public PuntoTres(Main main)
        {
            InitializeComponent();

            this._main = main;
        }

        private void btnDispararExcepcion_Click(object sender, EventArgs e)
        {
            try
            {
                Logic.DispararExcepcion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }
         }

        private void PuntoTres_FormClosed(object sender, FormClosedEventArgs e)
        {
            this._main.Visible = true;
        }
    }
}
