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

        private bool IsPresent(Control control, string name)
        {
            if (control.GetType().ToString() == "System.Windows.Forms.TextBox")
            {
                TextBox textBox = (TextBox)control;
                if (textBox.Text == "")
                {
                    MessageBox.Show(name + " is a required field.", "Entry Error");
                    textBox.Focus();
                    return false;
                }
            }
            return true;
        }

        private bool IsValidData()
        {
            if (vendorsBindingSource.Count > 0)
            {
                return
                    IsPresent(nameTextBox, "Name") &&
                    IsPresent(address1TextBox, "Address1") &&
                    IsPresent(cityTextBox, "City") &&
                    IsPresent(stateTextBox, "State") &&
                    IsPresent(zipCodeTextBox, "Zip Code");

            }
            else return false;

        }

        private void vendorsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            if (IsValidData())
            {
                try
                {
                    this.vendorsBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.payablesDataSet);
                }
                catch (NoNullAllowedException ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                    this.vendorsBindingSource.CancelEdit();
                }
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'payablesDataSet.Vendors' table. You can move, or remove it, as needed.
            this.vendorsTableAdapter.Fill(this.payablesDataSet.Vendors);

        }
    }
}
