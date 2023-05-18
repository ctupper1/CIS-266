using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendorMaintenance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void vendorsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vendorsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.payablesDataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'payablesDataSet11.States' table. You can move, or remove it, as needed.
            this.statesTableAdapter.Fill(this.payablesDataSet11.States);
            // TODO: This line of code loads data into the 'payablesDataSet1.Vendors' table. You can move, or remove it, as needed.
            this.vendorsTableAdapter.Fill(this.payablesDataSet1.Vendors);

        }

        private void address1Label_Click(object sender, EventArgs e)
        {

        }

        private void fillByVendorIDToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.vendorsTableAdapter.FillByVendorID(this.payablesDataSet1.Vendors, ((int)(System.Convert.ChangeType(vendorIDToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
