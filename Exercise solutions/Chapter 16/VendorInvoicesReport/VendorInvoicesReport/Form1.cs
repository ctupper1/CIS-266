﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VendorInvoicesReport
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'VendorInvoicesDataSet.VendorInvoicesDataTable' table. You can move, or remove it, as needed.
            this.VendorInvoicesDataTableTableAdapter.Fill(this.VendorInvoicesDataSet.VendorInvoicesDataTable);

            this.reportViewer1.RefreshReport();
        }
    }
}
