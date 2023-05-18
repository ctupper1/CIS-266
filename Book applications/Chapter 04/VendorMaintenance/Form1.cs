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

            try
            {
                this.statesTableAdapter.Fill(this.payablesDataSet.States);
                this.vendorsTableAdapter.Fill(this.payablesDataSet.Vendors);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Server error # " + ex.Number +
                    ";" + ex.Message, ex.GetType().ToString());
            }
        }

        private void FormatPhoneNumber(Object sender, ConvertEventArgs e)
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
                int vendorID = Convert.ToInt32(vendorIDToolStripTextBox.Text);
                this.vendorsTableAdapter.FillByVendorID(
                    this.payablesDataSet.Vendors, vendorID);
                if (vendorsBindingSource.Count == 0)
                    MessageBox.Show("No vendor found with this ID. "
                        + "Please try again.", "Vendor Not Found");
            }
            catch (FormatException)
            {
                MessageBox.Show("Vendor ID must be an integer.", "Entry Error");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error # " + ex.Number +
                    "; " + ex.Message, ex.GetType().ToString());
            }
        }

        private void bindingNavigatorCancelItem_Click(object sender, EventArgs e)
        {
            this.vendorsBindingSource.CancelEdit();
        }

        private void vendorsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                try
                {
                    this.vendorsBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.payablesDataSet);
                }
                catch (ArgumentException ex)
                {
                    // This block catches exceptions such as a value that's beyond
                    // the maximum length for a column in a dataset.
                    MessageBox.Show(ex.Message, "Argument Exception");
                    this.vendorsBindingSource.CancelEdit();
                }
                catch (DBConcurrencyException)
                {
                    MessageBox.Show("A concurrency error occurred. " +
                        "The row was not updated.", "Concurrency Exception");
                    this.vendorsTableAdapter.Fill(this.payablesDataSet.Vendors);
                }
                catch (DataException ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                    this.vendorsBindingSource.CancelEdit();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("SQL Server error # " + ex.Number +
                        ": " + ex.Message, ex.GetType().ToString());
                }
            }
        }

        private bool IsValidData()
        {
            if (vendorsBindingSource.Count > 0)
            {
                return
                    IsPresent(nameTextBox, "Name") &&
                    IsPresent(address1TextBox, "Address1") &&
                    IsPresent(cityTextBox, "City") &&
                    IsPresent(stateComboBox, "State") &&
                    IsPresent(zipCodeTextBox, "Zip code");
            }
            else
                return true;
        }

        private bool IsPresent(Control control, string name)
        {
            if (control.GetType().ToString() == "System.Windows.Forms.TextBox")
            {
                TextBox textBox = (TextBox) control;
                if (textBox.Text == "")
                {
                    MessageBox.Show(name + " is a required field.", "Entry Error");
                    textBox.Focus();
                    return false;
                }
            }
            else if (control.GetType().ToString() == "System.Windows.Forms.ComboBox")
            {
                ComboBox comboBox = (ComboBox) control;
                if (comboBox.SelectedIndex == -1)
                {
                    MessageBox.Show(name + " is a required field.", "Entry Error");
                    comboBox.Focus();
                    return false;
                }
            }
            return true;
        }
    }
}
