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
            vendorsTableAdapter.Fill(payablesDataSet.Vendors);
            payablesDataSet.WriteXml("C:\\ADO.NET 4 C#\\Chapter 15\\Vendors.xml");

        }

        private void btnSchema_Click(object sender, EventArgs e)
        {
            vendorsTableAdapter.Fill(payablesDataSet.Vendors);
            payablesDataSet.WriteXmlSchema("C:\\ADO.NET 4 C#\\Chapter 15\\VendorsSchema.xml");
        }

        private void btnXmlAndSchema_Click(object sender, EventArgs e)
        {
            vendorsTableAdapter.Fill(payablesDataSet.Vendors);
            payablesDataSet.WriteXml("C:\\ADO.NET 4 C#\\Chapter 15\\VendorsWithSchema.xml", XmlWriteMode.WriteSchema);
        }
    }
}
