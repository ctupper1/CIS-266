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
    public partial class frmVendorMaintenance : Form
    {
        public frmVendorMaintenance()
        {
            InitializeComponent();
        }

        private Vendor selectedVendor;

        private void btnGetVendor_Click(object sender, EventArgs e)
        {
            if (Validator.IsPresent(txtVendorID) &&
                Validator.IsInt32(txtVendorID))
            {
                int vendorID = Convert.ToInt32(txtVendorID.Text);
                this.GetVendor(vendorID);
            }
        }

        private void GetVendor(int vendorID)
        {
            try
            {
                // Step 6
                // Code a query to retrieve the selected vendor
                // and store the Vendor object in the class variable.

               // Step 7
                // Add code to load the State object for the vendor.

                this.DisplayVendor();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("No vendor found with this ID. " +
                    "Please try again.", "Vendor Not Found");
                this.ClearControls();
                txtVendorID.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void DisplayVendor()
        {
            txtName.Text = selectedVendor.Name;
            txtAddress1.Text = selectedVendor.Address1;
            txtAddress2.Text = selectedVendor.Address2;
            txtCity.Text = selectedVendor.City;
            txtState.Text = selectedVendor.State.StateName;
            txtZipCode.Text = selectedVendor.ZipCode;
            btnModify.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void ClearControls()
        {
            txtName.Text = "";
            txtAddress1.Text = "";
            txtAddress2.Text = "";
            txtCity.Text = "";
            txtState.Text = "";
            txtZipCode.Text = "";
            btnModify.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddModifyVendor addModifyVendorForm = new frmAddModifyVendor();
            addModifyVendorForm.addVendor = true;
            DialogResult result = addModifyVendorForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                selectedVendor = addModifyVendorForm.vendor;
                txtVendorID.Text = selectedVendor.VendorID.ToString();
                this.DisplayVendor();
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            frmAddModifyVendor addModifyVendorForm = new frmAddModifyVendor();
            addModifyVendorForm.addVendor = false;
            addModifyVendorForm.vendor = selectedVendor;
            DialogResult result = addModifyVendorForm.ShowDialog();
            if (result == DialogResult.OK || result == DialogResult.Retry)
            {
                selectedVendor = addModifyVendorForm.vendor;
                this.DisplayVendor();
            }
            else if (result == DialogResult.Abort)
            {
                txtVendorID.Text = "";
                this.ClearControls();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result =
                MessageBox.Show("Delete " + selectedVendor.Name + "?",
                "Confirm Delete", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    // Step 18
                    // Mark the row for deletion.
                    // Update the database.

                    // Step 22 (Optional)
                    // Add concurrency error handling
                    // NB. Place the Catch block above the one you insert in Step 18

                    txtVendorID.Text = "";
                    this.ClearControls();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
