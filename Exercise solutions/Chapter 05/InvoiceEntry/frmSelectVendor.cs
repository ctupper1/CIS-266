using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InvoiceEntry
{
    public partial class frmSelectVendor : Form
    {
        public frmSelectVendor()
        {
            InitializeComponent();
        }

        private void frmSelectVendor_Load(object sender, EventArgs e)
        {
            // Get the vendor rows that match the search string
            string name = this.Tag.ToString();
            this.vendorsTableAdapter.FillByVendorName(
                this.payablesDataSet.Vendors, name);

            if (vendorsDataGridView.Rows.Count == 0)
            {
                // No rows matched the search string
                this.Tag = -1;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void vendorsDataGridView_CellDoubleClick(
            object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            this.Tag = this.GetVendorID(rowIndex);
            this.DialogResult = DialogResult.OK;
        }

        private int GetVendorID(int rowIndex)
        {
            DataGridViewRow row = vendorsDataGridView.Rows[rowIndex];
            DataGridViewCell cell = row.Cells[0];
            int vendorID = (int)cell.Value;
            return vendorID;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int rowIndex = vendorsDataGridView.CurrentCell.RowIndex;
            this.Tag = this.GetVendorID(rowIndex);
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
