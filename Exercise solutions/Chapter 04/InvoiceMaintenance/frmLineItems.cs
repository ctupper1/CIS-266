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
    public partial class frmLineItems : Form
    {
        public frmLineItems()
        {
            InitializeComponent();
        }

        private void frmLineItems_Load(object sender, EventArgs e)
        {
            try
            {
                // Get the invoice ID
                int invoiceID = (int) this.Tag;
                // Fill the InvoiceLineItems table
                this.invoiceLineItemsTableAdapter.FillByInvoiceID(
                    this.payablesDataSet.InvoiceLineItems, invoiceID);
            }
            catch (InvalidCastException)
            {
                MessageBox.Show("Invoice ID is not an integer.", "Property Error");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Server error # " + ex.Number +
                    ": " + ex.Message, ex.GetType().ToString());
            }
        }
    }
}
