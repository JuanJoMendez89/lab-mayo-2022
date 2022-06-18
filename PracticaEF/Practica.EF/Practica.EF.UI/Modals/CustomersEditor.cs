using Practica.EF.Common.Exceptions;
using Practica.EF.Entities.Entities;
using Practica.EF.Entities.Models;
using Practica.EF.Logic.Logic;
using System;
using System.Drawing;
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

                if ((String.IsNullOrEmpty(txtID.Text) || String.IsNullOrWhiteSpace(txtID.Text)) && !_isEdit)
                {
                    txtID.BackColor = Color.Red;
                    return;
                }

                if (String.IsNullOrEmpty(txtCompanyName.Text) || String.IsNullOrWhiteSpace(txtCompanyName.Text))
                {
                    txtCompanyName.BackColor = Color.Red;
                    return;
                }

                CustomersDTO customer = new CustomersDTO
                {
                    CustomerID = txtID.Text.Trim(),
                    CompanyName = txtCompanyName.Text.Trim(),
                    ContactName = txtContactName.Text.Trim(),
                    ContactTitle = txtContactTitle.Text.Trim(),
                    Address = txtAddress.Text.Trim(),
                    City = txtCity.Text.Trim(),
                    Region = txtRegion.Text.Trim(),
                    Country = txtCountry.Text.Trim(),
                    PostalCode = txtPostalCode.Text.Trim(),
                    Phone = txtPhone.Text.Trim(),
                    Fax = txtFax.Text.Trim(),
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
            catch (DuplicateKeyException ex)
            {
                MessageBox.Show($"CustomerID \"{ex.Key}\" already exist.", "Error");
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
