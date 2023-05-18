using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceManagement
{
    public partial class frmAddInvoice : Form
    {
        int invoiceSequence;

        public frmAddInvoice()
        {
            InitializeComponent();
        }


        private void frmAddInvoice_Load(object sender, EventArgs e)
        {

            termsIDComboBox.SelectedIndexChanged -= termsIDComboBox_SelectedIndexChanged;


            //Initialise the form combo boxes and date time picker
            this.termsTableAdapter.Fill(this.payablesDataSet.Terms);
            termsIDComboBox.SelectedIndex = -1;

            this.gLAccountsTableAdapter.Fill(this.payablesDataSet.GLAccounts);
            accountNoComboBox.SelectedIndex = -1;

            invoiceDateDateTimePicker.Value = DateTime.Today;
            invoiceDateDateTimePicker.Checked = false;

            this.DisableControls();

            termsIDComboBox.SelectedIndexChanged += termsIDComboBox_SelectedIndexChanged;

        }

        private void DisableControls()
        {
            invoiceNumberTextBox.Enabled = false;
            invoiceDateDateTimePicker.Enabled = false;
            termsIDComboBox.Enabled = false;
            accountNoComboBox.Enabled = false;
            descriptionTextBox.Enabled = false;
            amountTextBox.Enabled = false;
            btnAccept.Enabled = false;
            btnAdd.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void fillByVendorIDToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                int vendorID = Convert.ToInt32(vendorIDToolStripTextBox.Text);
                this.vendorsTableAdapter.FillByVendorID(this.payablesDataSet.Vendors, vendorID);

                if(this.payablesDataSet.Vendors.Rows.Count == 0)
                {
                    MessageBox.Show("No vendor matching ID " + vendorID + ".", "Venfor Not Found");
                    vendorIDToolStripTextBox.Clear();
                    vendorIDToolStripTextBox.Focus();




                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByVendorNameToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                // open Select Form
                Form selectedVendorForm = new frmSelectVendor();
                string name = vendorNameToolStripTextBox.Text + "%";
                selectedVendorForm.Tag = name;
                DialogResult result = selectedVendorForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    // Get the ID of the selected vendor
                    int vendorID = (int)selectedVendorForm.Tag;

                    if (vendorID == -1) // No rows matched the search string
                    {
                        MessageBox.Show("No vendors were found with that name. " +
                            "Please try again.", "No Vendors Found");
                        vendorNameToolStripTextBox.Focus();
                    }
                    else
                    {
                        // Fill the dataset with the vendor row
                        vendorIDToolStripTextBox.Text = vendorID.ToString();
                        fillByVendorIDToolStripButton.PerformClick();
                        vendorNameToolStripTextBox.Text = "";
                    }
                }
                this.vendorsTableAdapter.FillByVendorName(this.payablesDataSet.Vendors, vendorNameToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void termsIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.CalculateDueDate();
        }

        private void CalculateDueDate()
        {
            int termsID = (int)termsIDComboBox.SelectedValue;
            int dueDays = (int)this.termsTableAdapter.GetDueDays(termsID);
            DateTime invoiceDate = invoiceDateDateTimePicker.Value;
            DateTime dueDate = invoiceDate.AddDays(dueDays);
            dueDaysTextBox.Text = dueDate.ToShortDateString();
        }
    }
}
