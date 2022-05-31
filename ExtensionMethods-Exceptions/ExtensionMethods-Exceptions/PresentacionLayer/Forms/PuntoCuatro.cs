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
        public PuntoCuatro()
        {
            InitializeComponent();
        }

        private void btnDispararExcepcion_Click(object sender, EventArgs e)
        {
            try
            {
                Logic.DispararExcepcionPersonalizada();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
