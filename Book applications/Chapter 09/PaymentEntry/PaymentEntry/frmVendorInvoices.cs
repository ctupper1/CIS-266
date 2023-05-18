using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PayablesData;

namespace PaymentEntry
{
    public partial class frmVendorInvoices : Form
    {
        public frmVendorInvoices()
        {
            InitializeComponent();
        }

        private Vendor vendor;
        private List<Vendor> vendorList;
        private List<Invoice> invoiceList;

        private void frmVendorInvoices_Load(object sender, EventArgs e)
        {
            this.GetVendorList();
            this.GetVendorData();
        }

        private void GetVendorList()
        {
            try
            {
                // Get the list of Vendor objects
                // and bind the combo box to the list
                vendorList = VendorDB.GetVendorsWithBalanceDue();
                nameComboBox.DataSource = vendorList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void GetVendorData()
        {
            int vendorID = (int)nameComboBox.SelectedValue;
            try
            {
                // Get a Vendor object for the selected vendor
                // and bind the text boxes to the object
                vendor = VendorDB.GetVendorNameAndAddress(vendorID);
                vendorBindingSource.Clear();
                vendorBindingSource.Add(vendor);

                // Get the list of Invoice objects
                // and bind the DataGridView control to the list
                invoiceList = InvoiceDB.GetUnpaidVendorInvoices(vendorID);
                invoiceDataGridView.DataSource = invoiceList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void nameComboBox_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            this.GetVendorData();
        }

        private void invoiceDataGridView_CellContentClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 11) // The Enter Payment button was clicked
            {
                // Get the invoice from the row
                int i = e.RowIndex;
                DataGridViewRow row = invoiceDataGridView.Rows[i];
                Invoice invoice = (Invoice)row.DataBoundItem;

                // Display the Payment Entry form to accept the payment
                frmPaymentEntry paymentEntryForm = new frmPaymentEntry();
                paymentEntryForm.vendorName = nameComboBox.Text;
                paymentEntryForm.invoice = invoice;
                DialogResult result = paymentEntryForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    CurrencyManager cm = (CurrencyManager)
                        invoiceDataGridView.BindingContext[invoiceList];
                    if (paymentEntryForm.invoice.BalanceDue == 0)
                    {
                        // Remove the invoice from the list
                        invoiceList.RemoveAt(i);
                        if (invoiceList.Count > 0)
                            // Refresh the data grid
                            cm.Refresh();
                        else
                        {
                            // Get a current vendor list and refresh the display
                            this.GetVendorList();
                            this.GetVendorData();
                        }
                    }
                    else
                    {
                        // Replace the invoice and refresh the data grid
                        invoiceList[i] = paymentEntryForm.invoice;
                        cm.Refresh();
                    }
                }
                else if (result == DialogResult.Retry)
                {
                    // A concurrency exception occurred
                    invoiceList = InvoiceDB.GetUnpaidVendorInvoices(vendor.VendorID);
                    if (invoiceList.Count > 0)
                        invoiceDataGridView.DataSource = invoiceList;
                    else
                    {
                        this.GetVendorList();
                        this.GetVendorData();
                    }
                }
            }
        }
    }
}
