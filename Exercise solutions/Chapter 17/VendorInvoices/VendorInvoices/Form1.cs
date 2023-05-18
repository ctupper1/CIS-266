using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VendorInvoices
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        PayablesDataContext payables = new PayablesDataContext();

        private void Form1_Load(object sender, EventArgs e)
        { 
            var vendors = from vendor in payables.Vendors
              orderby vendor.Name
              select new { vendor.VendorID, vendor.Name };
          
            nameComboBox.DataSource = vendors;

            this.GetVendorInvoices();
         }

        private void nameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.GetVendorInvoices();
        }

        private void GetVendorInvoices()
        {
            var selectedVendor =
                (from vendor in payables.Vendors
                 where vendor.VendorID == (int)nameComboBox.SelectedValue
                 select vendor).Single();

            vendorBindingSource.Clear();
            vendorBindingSource.Add(selectedVendor);

            invoiceBindingSource.DataSource = selectedVendor.Invoices;
        }

    

    }
}
