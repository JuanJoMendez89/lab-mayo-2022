using PresentacionLayer.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionLayer
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnPuntoUno_Click(object sender, EventArgs e)
        {
            PuntoUno form = new PuntoUno(this);

            form.Show();

            this.Visible = false;
        }

        private void btnPuntoDos_Click(object sender, EventArgs e)
        {
            PuntoDos form = new PuntoDos(this);

            form.Show();

            this.Visible = false;
        }

        private void btnPuntoTres_Click(object sender, EventArgs e)
        {
            PuntoTres form = new PuntoTres(this);

            form.Show();

            this.Visible = false;
        }

        private void btnPuntoCuatro_Click(object sender, EventArgs e)
        {
            PuntoCuatro form = new PuntoCuatro();

            form.Show();

            this.Visible = false;
        }
    }
}
