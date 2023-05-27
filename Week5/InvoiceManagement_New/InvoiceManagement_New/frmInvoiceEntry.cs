using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceManagement_New
{
    public partial class frmInvoiceEntry : Form
    {
        public frmInvoiceEntry()
        {
            InitializeComponent();
        }

        private void vendorsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vendorsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.payablesDataSet);

        }

        private void vendorsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.vendorsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.payablesDataSet);

        }

        private void frmInvoiceEntry_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'payablesDataSet.InvoiceLineItems' table. You can move, or remove it, as needed.
            this.invoiceLineItemsTableAdapter.Fill(this.payablesDataSet.InvoiceLineItems);
            // TODO: This line of code loads data into the 'payablesDataSet.Invoices' table. You can move, or remove it, as needed.
            this.invoicesTableAdapter.Fill(this.payablesDataSet.Invoices);
            // TODO: This line of code loads data into the 'payablesDataSet.Invoices' table. You can move, or remove it, as needed.
            this.invoicesTableAdapter.Fill(this.payablesDataSet.Invoices);
            // TODO: This line of code loads data into the 'payablesDataSet.Vendors' table. You can move, or remove it, as needed.
            this.vendorsTableAdapter.Fill(this.payablesDataSet.Vendors);

        }

        private void fillByVendorIDToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.vendorsTableAdapter.FillByVendorID(this.payablesDataSet.Vendors, ((int)(System.Convert.ChangeType(vendorIDToolStripTextBox.Text, typeof(int)))));
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
                this.vendorsTableAdapter.FillByVendorName(this.payablesDataSet.Vendors, vendorNameToolStripTextBox.Text) ;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
