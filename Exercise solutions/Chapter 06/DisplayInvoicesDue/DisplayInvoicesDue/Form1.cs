﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PayablesData;

namespace DisplayInvoicesDue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //List<Invoice> invoiceList;
            //try
            //{
            //    invoiceList = InvoiceDB.GetInvoicesDue();
            //    if (invoiceList.Count > 0)
            //    {
            //        Invoice invoice;
            //        for (int i = 0; i < invoiceList.Count; i++)
            //        {
            //            invoice = invoiceList[i];
            //            lvInvoices.Items.Add(invoice.InvoiceNumber);
            //            lvInvoices.Items[i].SubItems.Add(invoice.InvoiceDate.ToShortDateString());
            //            lvInvoices.Items[i].SubItems.Add(invoice.InvoiceTotal.ToString("c"));
            //            lvInvoices.Items[i].SubItems.Add(invoice.PaymentTotal.ToString("c"));
            //            lvInvoices.Items[i].SubItems.Add(invoice.CreditTotal.ToString("c"));
            //            lvInvoices.Items[i].SubItems.Add(invoice.BalanceDue().ToString("c"));
            //            lvInvoices.Items[i].SubItems.Add(invoice.DueDate.ToShortDateString());
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("All invoices are paid in full.",
            //            "No Balance Due");
            //        this.Close();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, ex.GetType().ToString());
            //    this.Close();
            //}
        }

        private void GetAllInvoicesToolStripButton_Click(object sender, EventArgs e)
        {
            lvInvoices.Items.Clear();
            List<Invoice> invoiceList;
            try
            {
                invoiceList = InvoiceDB.GetInvoicesDue();
                if (invoiceList.Count > 0)
                {
                    Invoice invoice;
                    for (int i = 0; i < invoiceList.Count; i++)
                    {
                        invoice = invoiceList[i];
                        lvInvoices.Items.Add(invoice.InvoiceNumber);
                        lvInvoices.Items[i].SubItems.Add(invoice.InvoiceDate.ToShortDateString());
                        lvInvoices.Items[i].SubItems.Add(invoice.InvoiceTotal.ToString("c"));
                        lvInvoices.Items[i].SubItems.Add(invoice.PaymentTotal.ToString("c"));
                        lvInvoices.Items[i].SubItems.Add(invoice.CreditTotal.ToString("c"));
                        lvInvoices.Items[i].SubItems.Add(invoice.BalanceDue().ToString("c"));
                        lvInvoices.Items[i].SubItems.Add(invoice.DueDate.ToShortDateString());
                    }
                    decimal totalBalanceDue = InvoiceDB.GetTotalBalanceDue();
                    txtTotalBalanceDue.Text = totalBalanceDue.ToString("c");
                }
                else
                {
                    MessageBox.Show("All invoices are paid in full.",
                        "No Balance Due");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                this.Close();
            }
        }

        private void GetVendorInvoicesToolStripButton_Click(object sender, EventArgs e)
        {
            lvInvoices.Items.Clear();
            List<Invoice> invoiceList;
            int vendorID = Convert.ToInt32(VendorIDToolStripTextBox.Text);
            try
            {
                invoiceList = InvoiceDB.GetVendorInvoicesDue(vendorID);
                if (invoiceList.Count > 0)
                {
                    Invoice invoice;
                    for (int i = 0; i < invoiceList.Count; i++)
                    {
                        invoice = invoiceList[i];
                        lvInvoices.Items.Add(invoice.InvoiceNumber);
                        lvInvoices.Items[i].SubItems.Add(invoice.InvoiceDate.ToShortDateString());
                        lvInvoices.Items[i].SubItems.Add(invoice.InvoiceTotal.ToString("c"));
                        lvInvoices.Items[i].SubItems.Add(invoice.PaymentTotal.ToString("c"));
                        lvInvoices.Items[i].SubItems.Add(invoice.CreditTotal.ToString("c"));
                        lvInvoices.Items[i].SubItems.Add(invoice.BalanceDue().ToString("c"));
                        lvInvoices.Items[i].SubItems.Add(invoice.DueDate.ToShortDateString());
                    }
                    decimal totalBalanceDue = InvoiceDB.GetVendorBalanceDue(vendorID);
                    txtTotalBalanceDue.Text = totalBalanceDue.ToString("c");
                }
                else
                {
                    MessageBox.Show("All invoices are paid in full.",
                        "No Balance Due");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                this.Close();
            }
        }
    }
}
