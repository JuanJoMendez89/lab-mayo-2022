using System;
using System.Windows.Forms;
using LogicaLayer.ExtensionMethods;

namespace PresentacionLayer.Forms
{
    public partial class PuntoUno : Form
    {
        private Main _main;
        public PuntoUno(Main main)
        {
            InitializeComponent();
            this._main = main;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                decimal valor = Convert.ToInt32(txtValor.Text);
                decimal resultado = valor.DividirPorCero();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception");
            }
            finally {
                MessageBox.Show("Fin de la operacion", "PuntoUno");
            }
            
        }
        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtValor.SoloNumerosYcoma(e);
        }

        private void txtValor_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtValor.Text.Length < 1)
            {
                btnAceptar.Enabled = false;
            }
            else
            {
                btnAceptar.Enabled = true;
            }
        }

        private void PuntoUno_FormClosed(object sender, FormClosedEventArgs e)
        {
            this._main.Show();
        }
    }
}
