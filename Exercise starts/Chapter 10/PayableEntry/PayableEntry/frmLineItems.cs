using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PayablesData;

namespace PayableEntry
{
    public partial class frmLineItems : Form
    {
        public frmLineItems()
        {
            InitializeComponent();
        }

        public int invoiceID;
        public string vendorName;
        public string invoiceNumber;

        private void frmLineItems_Load(object sender, EventArgs e)
        {
            List<LineItem> lineItemList =
                LineItemDB.GetInvoiceLineItems(invoiceID);
            lineItemDataGridView.DataSource = lineItemList;
            txtVendor.Text = vendorName;
            txtInvoiceNo.Text = invoiceNumber;
        }
    }
}
