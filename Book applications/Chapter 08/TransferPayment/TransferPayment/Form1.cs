using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PayablesData;

namespace TransferPayment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Invoice fromInvoice;
        Invoice toInvoice;

        private void btnGetFromInvoice_Click(object sender, EventArgs e)
        {
            if (Validator.IsPresent(txtFromInvoiceNo))
            {
                fromInvoice = InvoiceDB.GetInvoice(txtFromInvoiceNo.Text);
                if (fromInvoice != null)
                {
                    txtFromInvoiceDate.Text = fromInvoice.InvoiceDate.ToShortDateString();
                    txtFromInvoiceTotal.Text = fromInvoice.InvoiceTotal.ToString("c");
                    txtFromPaymentTotal.Text = fromInvoice.PaymentTotal.ToString("c");
                }
                else
                {
                    MessageBox.Show("An invoice was not found with that number.", 
                        "From Invoice Not Found");
                }
            }
        }

        private void btnGetToInvoice_Click(object sender, EventArgs e)
        {
            if (Validator.IsPresent(txtToInvoiceNo))
            {
                toInvoice = InvoiceDB.GetInvoice(txtToInvoiceNo.Text);
                if (toInvoice != null)
                {
                    txtToInvoiceDate.Text = toInvoice.InvoiceDate.ToShortDateString();
                    txtToInvoiceTotal.Text = toInvoice.InvoiceTotal.ToString("c");
                    txtToBalanceDue.Text = toInvoice.BalanceDue().ToString("c");
                }
                else
                {
                    MessageBox.Show("An invoice was not found with that number.", 
                        "To Invoice Not Found");
                }
            }
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (Validator.IsPresent(txtTransferAmount) &&
                Validator.IsDecimal(txtTransferAmount))
            {
                if (fromInvoice != null && toInvoice != null)
                {
                    decimal transferAmount = Convert.ToDecimal(txtTransferAmount.Text);
                    if (transferAmount <= fromInvoice.PaymentTotal)
                    {
                        if (transferAmount <= toInvoice.BalanceDue())
                        {
                            try
                            {
                                if (InvoiceDB.TransferPayment(fromInvoice,
                                    toInvoice, transferAmount))
                                {
                                    string message =
                                        "A payment of " +
                                        transferAmount.ToString("c") +
                                        " has been transferred from invoice number " +
                                        fromInvoice.InvoiceNumber +
                                        " to invoice number " +
                                        toInvoice.InvoiceNumber + ".";
                                    MessageBox.Show(message, "Transfer Complete");
                                }
                                else
                                {
                                    MessageBox.Show("The transfer was not processed. " +
                                        "Another user may have posted a payment to " +
                                        "one of the invoices.", "Transfer Not Processed");
                                }
                                this.ClearControls();
                                fromInvoice = null;
                                toInvoice = null;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, ex.GetType().ToString());
                            }
                        }
                        else
                            MessageBox.Show("Transfer amount cannot be more " +
                                "than the balance due.", "Data Entry Error");
                    }
                    else
                        MessageBox.Show("Transfer amount cannot be more " +
                            "than the payment total.", "Data Entry Error");
                }
                else
                    MessageBox.Show("You must get the From and To invoices " +
                        "before transferring a payment.", "Data Entry Error");
            }
        }

        private void ClearControls()
        {
            txtFromInvoiceNo.Text = "";
            txtFromInvoiceDate.Text = "";
            txtFromInvoiceTotal.Text = "";
            txtFromPaymentTotal.Text = "";
            txtToInvoiceNo.Text = "";
            txtToInvoiceDate.Text = "";
            txtToInvoiceTotal.Text = "";
            txtToBalanceDue.Text = "";
            txtTransferAmount.Text = "";
            txtFromInvoiceNo.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
