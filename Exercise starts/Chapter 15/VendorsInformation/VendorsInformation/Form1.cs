using System;
using System.Data;
using System.Windows.Forms;
using VendorsInformation.PayablesDataSetTableAdapters;

namespace VendorsInformation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private PayablesDataSet payablesDataSet = new PayablesDataSet();
        private VendorsTableAdapter vendorsTableAdapter = new VendorsTableAdapter();

        private void btnXML_Click(object sender, EventArgs e)
        {

        }

        private void btnSchema_Click(object sender, EventArgs e)
        {

        }

        private void btnXmlAndSchema_Click(object sender, EventArgs e)
        {

        }
    }
}
