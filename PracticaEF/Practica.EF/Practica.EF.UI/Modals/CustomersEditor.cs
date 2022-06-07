using Practica.EF.Entities.Entities;
using Practica.EF.Logic.Logic;
using Practica.EF.UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica.EF.UI.Modals
{
    public partial class CustomersEditor : Form
    {
        private CustomersLogic _customerLogic;
        private Customers _customer;
        private readonly bool _isEdit = false;
        private bool _isChangesSaved = false;

        public bool IsChangesSaved => this._isChangesSaved;

        public CustomersEditor(CustomersLogic customerLogic)
        {
            InitializeComponent();

            _customerLogic = customerLogic;
        }

        public CustomersEditor(Customers customer, CustomersLogic customerLogic, bool isEdit)
        {
            InitializeComponent();

            _customer = customer;

            _isEdit = isEdit;

            _customerLogic = customerLogic;
        }

        private void CustomersEditor_Load(object sender, EventArgs e)
        {
            if (_isEdit) {
                txtID.Enabled = false;

                txtID.Text = _customer.CustomerID;
                txtCompanyName.Text = _customer.CompanyName;
                txtContactName.Text = _customer.ContactName;
                txtContactTitle.Text = _customer.ContactTitle;
                txtAddress.Text = _customer.Address;
                txtCity.Text = _customer.City;
                txtRegion.Text = _customer.Region;
                txtPostalCode.Text = _customer.PostalCode;
                txtCountry.Text = _customer.Country;
                txtPhone.Text = _customer.Phone;
                txtFax.Text = _customer.Fax;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (String.IsNullOrEmpty(txtID.Text) && !_isEdit)
                {
                    txtID.BackColor = Color.Red;
                    return;
                }

                if (String.IsNullOrEmpty(txtCompanyName.Text))
                {
                    txtCompanyName.BackColor = Color.Red;
                    return;
                }

                Customers customer = new Customers
                {
                    CustomerID = txtID.Text,
                    CompanyName = txtCompanyName.Text,
                    ContactName = txtContactName.Text,
                    ContactTitle = txtContactTitle.Text,
                    Address = txtAddress.Text,
                    City = txtCity.Text,
                    Region = txtRegion.Text,
                    Country = txtCountry.Text,
                    PostalCode = txtPostalCode.Text,
                    Phone = txtPhone.Text,
                    Fax = txtFax.Text,
                };

                if (_isEdit)
                {
                    _customerLogic.Update(customer);
                }
                else {
                    _customerLogic.Add(customer);
                }

                _isChangesSaved = true;

                this.Close();
            }
            catch (SqlException) {
                MessageBox.Show("Duplicated Customer ID", "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }

        private void txtID_KeyUp(object sender, KeyEventArgs e)
        {
            if (String.IsNullOrEmpty(txtID.Text) && !_isEdit)
            {
                txtID.BackColor = Color.Red;
                return;
            }
            else
            {
                txtID.BackColor = Color.White;
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
