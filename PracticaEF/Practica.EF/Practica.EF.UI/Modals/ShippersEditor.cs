using Practica.EF.Entities.Entities;
using Practica.EF.Logic.Logic;
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
        private ShippersLogic _shippersLogic;
        private Shippers _shipper;
        private bool _isEdit;

        private bool _isChangesSaved = false;

        public bool IsChangesSaved => this._isChangesSaved;

        public ShippersEditor()
        {
            InitializeComponent();

            _shippersLogic = new ShippersLogic();
        }

        public ShippersEditor(Shippers shipper, bool isEdit)
        {
            InitializeComponent();

            _shippersLogic = new ShippersLogic();

            _shipper = shipper;

            _isEdit = isEdit;
        }

        private void ShippersEditor_Load(object sender, EventArgs e)
        {
            if (_isEdit) {
                txtCompanyName.Text = _shipper.CompanyName;
                txtPhone.Text = _shipper.Phone;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Shippers shipper = new Shippers
                {
                    ShipperID = (!_isEdit) ? 0 : _shipper.ShipperID,
                    CompanyName = txtCompanyName.Text,
                    Phone = txtPhone.Text
                };

                if (String.IsNullOrEmpty(txtCompanyName.Text))
                {
                    txtCompanyName.BackColor = Color.Red;
                    return;
                }

                if (_isEdit)
                {
                    _shippersLogic.Update(shipper);
                }
                else
                {
                    _shippersLogic.Add(shipper);
                }

                _isChangesSaved = true;

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }

        private void txtCompanyName_KeyUp(object sender, KeyEventArgs e)
        {
            if (String.IsNullOrEmpty(txtCompanyName.Text))
            {
                txtCompanyName.BackColor = Color.Red;
                return;
            }
            else
            {
                txtCompanyName.BackColor = Color.White;
            }
        }

    }
}
