using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InvoiceMaintenance
{
    public partial class frmInvoiceMaintenance : Form
    {
        public frmInvoiceMaintenance()
        {
            InitializeComponent();
        }

        private void fillByVendorIDToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                int vendorID = Convert.ToInt32(vendorIDToolStripTextBox.Text);
                this.vendorsTableAdapter.FillByVendorID(
                    this.payablesDataSet.Vendors, vendorID);
                if (vendorsBindingSource.Count > 0)
                    this.invoicesTableAdapter.FillByVendorID(
                        this.payablesDataSet.Invoices, vendorID);
                else
                    MessageBox.Show("No vendor found with this ID. "
                        + "Please try again.", "Vendor Not Found");
            }
            catch (FormatException)
            {
                MessageBox.Show("Vendor ID must be an integer.", "Entry Error");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void invoicesDataGridView_DataError(
            object sender, DataGridViewDataErrorEventArgs e)
        {
            int row = e.RowIndex + 1;
            string errorMessage = "A data error occurred.\n" +
                "Row: " + row + "\n" +
                "Error: " + e.Exception.Message;
            MessageBox.Show(errorMessage, "Data Error");
        }

        private void invoicesDataGridView_CellContentClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8) //View Line Items button clicked
            {
                // Get the ID of the selected invoice
                int i = e.RowIndex;
                DataGridViewRow row = invoicesDataGridView.Rows[i];
                DataGridViewCell cell = row.Cells[0];
                int invoiceID = (int)cell.Value;

                // Display the Line Items form
                Form lineItemsForm = new frmLineItems();
                lineItemsForm.Tag = invoiceID;
                lineItemsForm.ShowDialog();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                this.invoicesBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.payablesDataSet);
            }
            catch (DBConcurrencyException)
            {
                MessageBox.Show("A concurrency error occurred. " +
                    "The row was not updated.", "Concurrency Exception");
                this.vendorsTableAdapter.Fill(this.payablesDataSet.Vendors);
            }
            catch (DataException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                this.invoicesBindingSource.CancelEdit();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Server error # " + ex.Number +
                    ": " + ex.Message, ex.GetType().ToString());
            }
        }
    }
}
