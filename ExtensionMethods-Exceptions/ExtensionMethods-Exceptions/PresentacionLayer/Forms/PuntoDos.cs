using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaLayer.ExtensionMethods;

namespace PresentacionLayer.Forms
{
    public partial class PuntoDos : Form
    {
        private Main _main;

        public PuntoDos(Main main)
        {
            InitializeComponent();

            this._main = main;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                decimal valor1 = Convert.ToInt32(txtValor1.Text);
                decimal valor2 = Convert.ToInt32(txtValor2.Text);

                decimal resultado = valor1.Dividir(valor2);

                MessageBox.Show($"El resultado es {resultado.ToString("0.00")}", "Division");
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message, "Solo Chuck Norris divide por cero!");
            }
            catch (FormatException ex) {
                MessageBox.Show("Seguro Ingreso una letra o no ingreso nada!", ex.GetType().Name);
            }
        }

        private void PuntoDos_FormClosed(object sender, FormClosedEventArgs e)
        {
            this._main.Visible = true;
        }
    }
}
