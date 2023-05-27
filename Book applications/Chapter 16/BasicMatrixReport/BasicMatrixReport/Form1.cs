using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BasicMatrixReport
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // test push

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'PayablesDataSet.InvoiceStateCityDataTable' table. You can move, or remove it, as needed.
            this.InvoiceStateCityDataTableTableAdapter.Fill(this.PayablesDataSet.InvoiceStateCityDataTable);

            this.reportViewer1.RefreshReport();
        }
    }
}
