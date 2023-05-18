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
    public partial class frmPaymentEntry : Form
    {
        public frmPaymentEntry()
        {
            InitializeComponent();
        }

        public string vendorName;
        public Invoice invoice;

        private void frmPaymentEntry_Load(object sender, EventArgs e)
        {
            txtVendor.Text = vendorName;
            invoiceBindingSource.Add(invoice);
            txtPayment.Text = invoice.BalanceDue.ToString("N2");
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (Validator.IsPresent(txtPayment) &&
                Validator.IsDecimal(txtPayment) &&
                Validator.IsWithinRange(txtPayment, 1, (decimal)invoice.BalanceDue))
            {
                Invoice newInvoice = new Invoice();
                this.PutNewInvoice(newInvoice);
                try
                {
                    if (!InvoiceDB.UpdatePayment(invoice, newInvoice))
                    {
                        MessageBox.Show("Another user has updated or deleted " +
                            "that invoice.", "Concurrency Error");
                        this.DialogResult = DialogResult.Retry;
                    }
                    else
                    {
                        invoice = newInvoice;
                        this.DialogResult = DialogResult.OK;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }

        private void PutNewInvoice(Invoice newInvoice)
        {
            newInvoice.InvoiceID = invoice.InvoiceID;
            newInvoice.VendorID = invoice.VendorID;
            newInvoice.InvoiceNumber = invoice.InvoiceNumber;
            newInvoice.InvoiceDate = invoice.InvoiceDate;
            newInvoice.InvoiceTotal = invoice.InvoiceTotal;
            decimal payment = Convert.ToDecimal(txtPayment.Text);
            newInvoice.PaymentTotal = invoice.PaymentTotal + payment;
            newInvoice.CreditTotal = invoice.CreditTotal;
            newInvoice.TermsID = invoice.TermsID;
            newInvoice.DueDate = invoice.DueDate;
            newInvoice.PaymentDate = DateTime.Today;
        }
    }
}
