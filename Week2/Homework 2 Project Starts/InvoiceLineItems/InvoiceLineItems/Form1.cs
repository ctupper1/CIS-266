using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceLineItems
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<LineItem> lineItems = null;
        private List<Invoice> invoices = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            lineItems = LineItemDB.GetLineItems();
            invoices = InvoiceDB.GetInvoices();

            // Use LINQ to retrieve item and invoice data
            var items = from item in lineItems
                        join invoice in invoices on item.InvoiceID equals invoice.InvoiceID
                        orderby invoice.InvoiceDate
                        where item != null
                        select new
                        {
                            item.InvoiceID,
                            invoice.InvoiceDate,
                            invoice.InvoiceTotal,
                            item.ProductCode,
                            item.UnitPrice,
                            item.Quantity,
                            item.ItemTotal
                        };
            int i = 0;
            int invoiceID = 0;

            // loop through and add new items to listbox
            foreach ( var item in items )
            {
                // make 
                if (item.InvoiceID != invoiceID)
                {
                    listView1.Items.Add( item.InvoiceID.ToString() );
                    invoiceID = item.InvoiceID;
                    listView1.Items[i].SubItems.Add(Convert.ToDateTime(item.InvoiceDate).ToShortDateString());     
                    listView1.Items[i].SubItems.Add(item.InvoiceTotal.ToString("c"));
                }
                else
                {
                    listView1.Items.Add(" ");
                    listView1.Items[i].SubItems.Add(" ");
                    listView1.Items[i].SubItems.Add(" ");
                }

                listView1.Items[i].SubItems.Add(item.ProductCode);
                listView1.Items[i].SubItems.Add(item.UnitPrice.ToString("c"));
                listView1.Items[i].SubItems.Add(item.Quantity.ToString());
                listView1.Items[i].SubItems.Add(item.ItemTotal.ToString("c"));
                i += 1;
            }
        }

    }
}
