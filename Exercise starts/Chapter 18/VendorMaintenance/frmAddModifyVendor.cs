using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Objects;

namespace VendorMaintenance
{
    public partial class frmAddModifyVendor : Form
    {
        public frmAddModifyVendor()
        {
            InitializeComponent();
        }

        public bool addVendor;
        public Vendor vendor;

        private void frmAddModifyVendor_Load(object sender, EventArgs e)
        {
            this.LoadComboBoxes();
            if (addVendor)
            {
                this.Text = "Add Vendor";
                cboStates.SelectedIndex = -1;
                cboTerms.SelectedIndex = -1;
                cboAccounts.SelectedIndex = -1;
            }
            else
            {
                this.Text = "Modify Vendor";
                this.DisplayVendorData();
            }
        }
        private void LoadComboBoxes()
        {
            try
            {
                // Step 10
                // Code a query to retrieve the required information from
                // the States table, and sort the results by state name.
                // Bind the State combo box to the query results.

                // Code a query to retrieve the required information from
                // the Terms table, and sort the results by description.
                // Bind the Terms combo box to the query results.

                // Code a query to retrieve the required information from
                // the GLAccounts table, and sort the results by description.
                // Bind the Account combo box to the query results.
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void DisplayVendorData()
        {
            txtName.Text = vendor.Name;
            txtAddress1.Text = vendor.Address1;
            txtAddress2.Text = vendor.Address2;
            txtCity.Text = vendor.City;
            cboStates.SelectedValue = vendor.State.StateCode;
            txtZipCode.Text = vendor.ZipCode;
            cboTerms.SelectedValue = vendor.Terms.TermsID;
            cboAccounts.SelectedValue = vendor.GLAccount.AccountNo;
            if (vendor.Phone == "")
                txtPhone.Text = "";
            else
                txtPhone.Text = FormattedPhoneNumber(vendor.Phone);
            txtFirstName.Text = vendor.ContactFName;
            txtLastName.Text = vendor.ContactLName;
        }

        private string FormattedPhoneNumber(string phone)
        {
            return phone.Substring(0, 3) + "." +
                phone.Substring(3, 3) + "." +
                phone.Substring(6, 4);
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                if (addVendor)
                {
                    vendor = new Vendor();
                    this.PutVendorData(vendor);
                    // Step 12
                    // Add the new vendor to the collection of vendors.

                    try
                    {
                        // Update the database.

                        this.DialogResult = DialogResult.OK;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }
                else
                {
                    this.PutVendorData(vendor);
                    try
                    {
                        // Step 15
                        // Update the database.

                        this.DialogResult = DialogResult.OK;
                    }
                        // Step 22 (Optional)

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }
            }

        }
        private bool IsValidData()
        {
            if (Validator.IsPresent(txtName) &&
                Validator.IsPresent(txtAddress1) &&
                Validator.IsPresent(txtCity) &&
                Validator.IsPresent(cboStates) &&
                Validator.IsPresent(txtZipCode) &&
                Validator.IsInt32(txtZipCode) &&
                Validator.IsPresent(cboTerms) &&
                Validator.IsPresent(cboAccounts))
            {
            
                    if (txtPhone.Text != "")
                    {
                        if (Validator.IsPhoneNumber(txtPhone))
                            return true;
                        else
                            return false;
                    }
                    else
                        return true;
            }
            else
                return false;
        }

        private void PutVendorData(Vendor vendor)
        {
            vendor.Name = txtName.Text;
            vendor.Address1 = txtAddress1.Text;
            vendor.Address2 = txtAddress2.Text;
            vendor.City = txtCity.Text;
            vendor.State = (State)cboStates.SelectedItem;
            vendor.ZipCode = txtZipCode.Text;
            vendor.Terms = (Terms)cboTerms.SelectedItem;
            vendor.GLAccount = (GLAccount)cboAccounts.SelectedItem;
            vendor.Phone = txtPhone.Text.Replace(".", "");
            vendor.ContactFName = txtFirstName.Text;
            vendor.ContactLName = txtLastName.Text;
        }
    }
}
