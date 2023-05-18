using System;
using System.Data;
using System.Linq;
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
                var states = from state in PayablesEntity.payables.States
                             orderby state.StateName
                             select state;
                cboStates.DataSource = states;
                cboStates.DisplayMember = "StateName";
                cboStates.ValueMember = "StateCode";

                var terms = from term in PayablesEntity.payables.Terms
                            orderby term.Description
                            select term;
                cboTerms.DataSource = terms;
                cboTerms.DisplayMember = "Description";
                cboTerms.ValueMember = "TermsID";

                var accounts = from account in PayablesEntity.payables.GLAccounts
                               orderby account.Description
                               select account;
                cboAccounts.DataSource = accounts;
                cboAccounts.DisplayMember = "Description";
                cboAccounts.ValueMember = "AccountNo";
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
                    PayablesEntity.payables.AddToVendors(vendor);
                    try
                    {
                        PayablesEntity.payables.SaveChanges();
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
                        PayablesEntity.payables.SaveChanges();
                        this.DialogResult = DialogResult.OK;
                    }
                    catch (OptimisticConcurrencyException)
                    {
                        PayablesEntity.payables.Refresh(RefreshMode.StoreWins, vendor);
                        if (vendor.EntityState == EntityState.Detached)
                        {
                            MessageBox.Show("Another user has deleted " +
                                "that vendor.", "Concurrency Error");
                            this.DialogResult = DialogResult.Abort;
                        }
                        else
                        {
                            MessageBox.Show("Another user has updated " +
                                "that vendor.", "Concurrency Error");
                            this.DialogResult = DialogResult.Retry;
                        }
                    }
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
                State state = (State)cboStates.SelectedItem;
                if (Validator.IsStateZipCode(txtZipCode, state.FirstZipCode,
                    state.LastZipCode))
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
