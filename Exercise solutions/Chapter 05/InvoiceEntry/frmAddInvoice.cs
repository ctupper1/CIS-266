using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InvoiceEntry
{
    public partial class frmAddInvoice : Form
    {
        public frmAddInvoice()
        {
            InitializeComponent();
        }

        int invoiceSequence;

        private void frmAddInvoice_Load(object sender, EventArgs e)
        {
            termsIDComboBox.SelectedIndexChanged -= 
                termsIDComboBox_SelectedIndexChanged;

            // Initialize the combo boxes and date time picker
            this.termsTableAdapter.Fill(this.payablesDataSet.Terms);
            termsIDComboBox.SelectedIndex = -1;

            this.gLAccountsTableAdapter.Fill(this.payablesDataSet.GLAccounts);
            accountNoComboBox.SelectedIndex = -1;

            invoiceDateDateTimePicker.Value = DateTime.Today;
            invoiceDateDateTimePicker.Checked = false;

            // Disable the controls on the form so the user can't enter
            // any data until a vendor is selected
            this.DisableControls();

            termsIDComboBox.SelectedIndexChanged +=
                termsIDComboBox_SelectedIndexChanged;
        }

        private void DisableControls()
        {
            invoiceNumberTextBox.Enabled = false;
            invoiceDateDateTimePicker.Enabled = false;
            termsIDComboBox.Enabled = false;
            accountNoComboBox.Enabled = false;
            descriptionTextBox.Enabled = false;
            amountTextBox.Enabled = false;
            btnAdd.Enabled = false;
            btnAccept.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void fillByVendorIDToolStripButton_Click(
            object sender, EventArgs e)
        {
            try
            {
                int vendorID = Convert.ToInt32(vendorIDToolStripTextBox.Text);
                this.vendorsTableAdapter.FillByVendorID(
                    this.payablesDataSet.Vendors, vendorID);

                if (this.payablesDataSet.Vendors.Rows.Count == 0)
                {
                    MessageBox.Show("No vendor found with ID " + vendorID + ".",
                        "Vendor Not Found");
                    vendorIDToolStripTextBox.Text = "";
                }
                else
                {
                    // Enable the form controls so the user can enter the invoice
                    this.EnableControls();

                    // Remove the new invoice row that was added if a vendor
                    // was previously selected
                    this.invoicesBindingSource.CancelEdit();

                    // Remove any line items that have been added
                    for (int i = invoiceLineItemsDataGridView.Rows.Count - 1; 
                        i > 0; i--)
                    {
                        invoiceLineItemsDataGridView.Rows.RemoveAt(i);
                    }

                    // Add a new row to the Invoices table
                    this.invoicesBindingSource.AddNew();

                    // Initialize the vendor ID and invoice date
                    vendorIDTextBox.Text = vendorID.ToString();
                    invoiceDateDateTimePicker.Value = DateTime.Today;
                    invoiceDateDateTimePicker.Checked = false;

                    // Get the vendor defaults and initialize the combo boxes
                    int defaultTermsID = 
                        (int)this.vendorsTableAdapter.GetDefaultTermsID(vendorID);
                    termsIDComboBox.SelectedValue = defaultTermsID;

                    int defaultAccountNo = 
                        (int)this.vendorsTableAdapter.GetDefaultAccountNo(vendorID);
                    accountNoComboBox.SelectedValue = defaultAccountNo;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Vendor ID must be an integer.", "Entry Error");
                vendorIDToolStripTextBox.Focus();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error # " + ex.Number + 
                    "; " + ex.Message, ex.GetType().ToString());
            }
        }

        private void EnableControls()
        {
            invoiceNumberTextBox.Enabled = true;
            invoiceDateDateTimePicker.Enabled = true;
            termsIDComboBox.Enabled = true;
            accountNoComboBox.Enabled = true;
            descriptionTextBox.Enabled = true;
            amountTextBox.Enabled = true;
            btnAdd.Enabled = true;
            btnAccept.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void termsIDComboBox_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            this.CalculateDueDate();
        }

        private void CalculateDueDate()
        {
            if(termsIDComboBox.SelectedIndex != null)
            {            
                int termsID = (int)termsIDComboBox.SelectedValue;
                int dueDays = (int)this.termsTableAdapter.GetDueDays(termsID);
                DateTime invoiceDate = invoiceDateDateTimePicker.Value;
                DateTime dueDate = invoiceDate.AddDays(dueDays);
                dueDateTextBox.Text = dueDate.ToShortDateString();
            }

        }

        private void fillByNameToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a search string for the name
                string name = nameToolStripTextBox.Text + "%";

                // Display the Select Vendor form
                Form selectedVendorForm = new frmSelectVendor();
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
                        nameToolStripTextBox.Focus();
                    }
                    else
                    {
                        // Fill the dataset with the vendor row
                        vendorIDToolStripTextBox.Text = vendorID.ToString();
                        fillByVendorIDToolStripButton.PerformClick();
                        nameToolStripTextBox.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void invoiceDateDateTimePicker_ValueChanged(
            object sender, EventArgs e)
        {
            if (vendorIDTextBox.Text != "")
                this.CalculateDueDate();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Check that the line item data is valid
            if (IsValidLineItem())
            {
                // Add a new row to the InvoiceLineItems table
                invoiceLineItemsBindingSource.AddNew();

                // Set the values of the row in the data grid
                int rowIndex = invoiceLineItemsDataGridView.Rows.Count - 1;
                DataGridViewRow row = invoiceLineItemsDataGridView.Rows[rowIndex];
                DataGridViewCell cell = row.Cells[0];
                cell.Value = 1;
                invoiceSequence += 1;
                cell = row.Cells[1];
                cell.Value = invoiceSequence;
                cell = row.Cells[2];
                cell.Value = accountNoComboBox.SelectedValue;
                cell = row.Cells[3];
                cell.Value = accountNoComboBox.Text;
                cell = row.Cells[4];
                cell.Value = descriptionTextBox.Text;
                cell = row.Cells[5];
                cell.Value = amountTextBox.Text;

                // Save the line item to the table
                invoiceLineItemsBindingSource.EndEdit();

                // Calculate the invoice total
                this.GetInvoiceTotal();
                
                // Prepare for the next entry
                descriptionTextBox.Text = "";
                amountTextBox.Text = "";
                descriptionTextBox.Focus();
            }
        }

        private bool IsValidLineItem()
        {
            if (IsPresent(descriptionTextBox, "Description") &&
                IsPresent(amountTextBox, "Amount") &&
                IsDecimal(amountTextBox, "Amount"))
                return true;
            else
                return false;
        }

        private bool IsPresent(TextBox textBox, string name)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(name + " is a required field.", "Entry Error");
                textBox.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool IsDecimal(TextBox textBox, string name)
        {
            try
            {
                Convert.ToDecimal(textBox.Text);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show(name + " must be a decimal value.", "Entry Error");
                textBox.Focus();
                return false;
            }
        }

        private void GetInvoiceTotal()
        {
            DataGridViewCell cell;
            decimal amount;
            decimal invoiceTotal = 0;
            foreach (DataGridViewRow row in invoiceLineItemsDataGridView.Rows)
            {
                cell = row.Cells[5];
                amount = (decimal)cell.Value;
                invoiceTotal += amount;
            }
            InvoiceTotalTextBox.Text = invoiceTotal.ToString("c");
        }

        private void invoiceLineItemsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                // Remove the line item when the user clicks the Delete button
                invoiceLineItemsDataGridView.Rows.RemoveAt(e.RowIndex);

                // Reset the invoice sequence for all line items
                DataGridViewCell cell;
                DataGridViewRow row;
                for (int i = 1; i <= invoiceLineItemsDataGridView.Rows.Count; i++)
                {
                    row = invoiceLineItemsDataGridView.Rows[i - 1];
                    cell = row.Cells[1];
                    invoiceSequence = i;
                    cell.Value = invoiceSequence;
                }
                this.GetInvoiceTotal();
                descriptionTextBox.Focus();
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (IsValidInvoice())
            {
                try
                {
                    // Save the invoice to the Invoices data table
                    invoicesBindingSource.EndEdit();

                    // Update the Invoices table
                    invoicesTableAdapter.Update(this.payablesDataSet.Invoices);

                    // Get the generated invoice ID
                    int invoiceID = (int)invoicesTableAdapter.GetLastIdentityValue();

                    // Set the final invoice ID for all line items
                    DataGridViewCell cell;
                    foreach (DataGridViewRow row in invoiceLineItemsDataGridView.Rows)
                    {
                        cell = row.Cells[0];
                        cell.Value = invoiceID;
                    }

                    // Update the InvoiceLineItems table
                    invoiceLineItemsTableAdapter.Update(
                        this.payablesDataSet.InvoiceLineItems);

                    // Clear the data tables
                    this.payablesDataSet.Vendors.Rows.Clear();
                    this.payablesDataSet.Invoices.Rows.Clear();
                    this.payablesDataSet.InvoiceLineItems.Rows.Clear();

                    // Prepare the form for another entry
                    invoiceSequence = 0;
                    this.ClearControls();
                    this.DisableControls();
                }
                catch (ConstraintException)
                {
                    MessageBox.Show("A constraint violation has occurred. " +
                        "The row was not added.", "Constraint Error");
                }
                catch (DataException ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("SQL Server error # " + ex.Number +
                        ": " + ex.Message, ex.GetType().ToString());
                }
            }
        }

        private bool IsValidInvoice()
        {
            if (IsPresent(invoiceNumberTextBox, "Invoice Number"))
            {
                if (invoiceDateDateTimePicker.Checked == true)
                {
                    if (invoiceLineItemsDataGridView.Rows.Count > 0)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("You must enter at least one line item.",
                            "Entry Error");
                        descriptionTextBox.Focus();
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("You must select an invoice date.",
                        "Entry Error");
                    invoiceDateDateTimePicker.Focus();
                    return false;
                }
            }
            return false;
        }

        private void ClearControls()
        {
            vendorIDToolStripTextBox.Text = "";
            vendorIDTextBox.Text = "";
            invoiceDateDateTimePicker.Value = DateTime.Today;
            invoiceDateDateTimePicker.Checked = false;
            termsIDComboBox.SelectedIndex = -1;
            dueDateTextBox.Text = "";
            accountNoComboBox.SelectedIndex = -1;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Cancel the current edit operation and clear the data tables
            invoicesBindingSource.CancelEdit();
            this.payablesDataSet.Vendors.Rows.Clear();
            this.payablesDataSet.InvoiceLineItems.Rows.Clear();

            // Prepare the form for another entry
            invoiceSequence = 0;
            this.ClearControls();
            this.DisableControls();
        }

        private void frmAddInvoice_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnCancel.PerformClick();
        }
    }
}
