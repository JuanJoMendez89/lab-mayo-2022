using poo_transportes.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace poo_transportes
{
    public partial class MainForm : Form
    {
        private List<TransportePublico> _listaTransportes = new List<TransportePublico>();
        private int _cantidadOmnibus = 0;
        private int _cantidadTaxis = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAddOmnibus_Click(object sender, EventArgs e)
        {
            int pasajeros = String.IsNullOrEmpty(txtPasajerosOmnibus.Text) ? 0 : Convert.ToInt32(txtPasajerosOmnibus.Text);

            if (_cantidadOmnibus < 5)
            {
                _listaTransportes.Add(new Omnibus(pasajeros));

                _cantidadOmnibus++;

                txtPasajerosOmnibus.Text = "";

                lblCantidadOmnibus.Text = String.Format("Cantidad pasajeros ({0}/5):", _cantidadOmnibus);

                this.ActiveControl = txtPasajerosOmnibus;
            }

            if (_cantidadOmnibus == 5)
            {
                txtPasajerosOmnibus.Enabled = false;
                btnAddOmnibus.Enabled = false;
            }

            if (_listaTransportes.Count > 0) {
                btnProcesar.Enabled = true;
                btnReset.Enabled = true;
            }
        }

        private void btnAddTaxi_Click(object sender, EventArgs e)
        {
            int pasajeros = String.IsNullOrEmpty(txtPasajerosTaxi.Text) ? 0 : Convert.ToInt32(txtPasajerosTaxi.Text);

            if (_cantidadTaxis < 5)
            {
                _listaTransportes.Add(new Taxi(pasajeros));

                _cantidadTaxis++;

                txtPasajerosTaxi.Text = "";

                lblCantidadTaxis.Text = String.Format("Cantidad pasajeros ({0}/5):", _cantidadTaxis);

                this.ActiveControl = txtPasajerosTaxi;
            }

            if(_cantidadTaxis == 5) {
                txtPasajerosTaxi.Enabled = false;
                btnAddTaxi.Enabled = false;
            }

            if (_listaTransportes.Count > 0)
            {
                btnProcesar.Enabled = true;
                btnReset.Enabled = true;
            }

        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            StringBuilder sbOmnibus = new StringBuilder();
            StringBuilder sbTaxis = new StringBuilder();

            int indexOmnibus = 0;
            int indexTaxis = 0;

            foreach (TransportePublico t in _listaTransportes) {
                if (t.GetType() == typeof(Omnibus)) {

                    sbOmnibus.Append(String.Format("Omnibus {0}: {1} pasajeros.\r\n", indexOmnibus + 1, t.GetPasajeros()));
                    indexOmnibus++;
                }

                if (t.GetType() == typeof(Taxi)) {
                    sbTaxis.Append(String.Format("Taxi {0}: {1} pasajeros.\r\n", indexTaxis + 1, t.GetPasajeros()));
                    indexTaxis++;
                }
            }

            txtSalidaOmnibus.Text = sbOmnibus.ToString();
            txtSalidaTaxis.Text = sbTaxis.ToString();

            txtPasajerosOmnibus.Enabled = false;
            btnAddOmnibus.Enabled = false;

            txtPasajerosTaxi.Enabled = false;
            btnAddTaxi.Enabled = false;

            btnProcesar.Enabled = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            _listaTransportes.Clear();

            _cantidadOmnibus = 0;
            _cantidadTaxis = 0;

            txtPasajerosOmnibus.Text = "";
            txtPasajerosTaxi.Text = "";

            txtSalidaOmnibus.Text = "";
            txtSalidaTaxis.Text = "";

            txtPasajerosOmnibus.Enabled = true;
            btnAddOmnibus.Enabled = true;

            txtPasajerosTaxi.Enabled = true;
            btnAddTaxi.Enabled = true;

            lblCantidadOmnibus.Text = String.Format("Cantidad pasajeros ({0}/5):", _cantidadOmnibus);
            lblCantidadTaxis.Text = String.Format("Cantidad pasajeros ({0}/5):", _cantidadTaxis);

            btnProcesar.Enabled = false;
            btnReset.Enabled = false;
        }

        private void txtPasajerosOmnibus_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtPasajerosTaxi_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        public void SoloNumeros(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
