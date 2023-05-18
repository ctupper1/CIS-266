using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VendorMaintenance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Binding b = phoneTextBox.DataBindings["Text"];
            b.Format += FormatPhoneNumber;
            b.Parse += UnformatPhoneNumber;

            this.statesTableAdapter.Fill(this.payablesDataSet.States);
            //this.vendorsTableAdapter.Fill(this.payablesDataSet.Vendors);
            stateComboBox.SelectedIndex = -1;
        }

        private void FormatPhoneNumber(object sender, ConvertEventArgs e)
        {
            if (e.Value.GetType().ToString() == "System.String")
            {
                string s = e.Value.ToString();
                if (IsInt64(s))
                {
                    if (s.Length == 10)
                    {
                        e.Value = s.Substring(0, 3) + "." +
                                  s.Substring(3, 3) + "." +
                                  s.Substring(6, 4);
                    }
                }
            }
        }

        private bool IsInt64(string s)
        {
            try
            {
                Convert.ToInt64(s);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private void UnformatPhoneNumber(Object sender, ConvertEventArgs e)
        {
            if (e.Value.GetType().ToString() == "System.String")
            {
                string s = e.Value.ToString();
                e.Value = s.Replace(".", "");
            }
        }

        private void fillByVendorIDToolStripButton_Click(
            object sender, EventArgs e)
        {
            try
            {
                this.vendorsTableAdapter.FillByVendorID(
                    this.payablesDataSet.Vendors,
                    ((int)(System.Convert.ChangeType(
                    vendorIDToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void bindingNavigatorCancelItem_Click(object sender, EventArgs e)
        {
            this.vendorsBindingSource.CancelEdit();
        }

        private void vendorsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vendorsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.payablesDataSet);
        }

        private void fillByStateToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.vendorsTableAdapter.FillByState(this.payablesDataSet.Vendors, 
                    stateToolStripTextBox1.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
