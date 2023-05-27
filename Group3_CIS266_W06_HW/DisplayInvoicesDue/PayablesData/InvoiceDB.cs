﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace PayablesData
{
    public static class InvoiceDB
    {
        public static List<Invoice> GetInvoicesDue()
        {
            List<Invoice> invoiceList = new List<Invoice>();
            SqlConnection connection = PayablesDB.GetConnection();
            string selectStatement =
                "SELECT InvoiceNumber, InvoiceDate, InvoiceTotal, " +
                "PaymentTotal, CreditTotal, DueDate " +
                "FROM Invoices " +
                "WHERE InvoiceTotal - PaymentTotal - CreditTotal > 0 " +
                "ORDER BY DueDate";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    Invoice invoice = new Invoice();
                    invoice.InvoiceNumber = reader["InvoiceNumber"].ToString();
                    invoice.InvoiceDate = (DateTime)reader["InvoiceDate"];
                    invoice.InvoiceTotal = (decimal)reader["InvoiceTotal"];
                    invoice.PaymentTotal = (decimal)reader["PaymentTotal"];
                    invoice.CreditTotal = (decimal)reader["CreditTotal"];
                    invoice.DueDate = (DateTime)reader["DueDate"];
                    invoiceList.Add(invoice);
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return invoiceList;
        }

        public static decimal GetTotalBalanceDue()
        {
            decimal balanceDue = 0;

            SqlConnection connection = PayablesDB.GetConnection();
            string selectStatement =
                "SELECT SUM(InvoiceTotal - PaymentTotal - CreditTotal) " +
                "AS BalanceDue " +
                "FROM Invoices ";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            try
            {
                connection.Open();
                balanceDue = Convert.ToDecimal(selectCommand.ExecuteScalar());                
            }
            catch (SqlException ex) 
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return balanceDue;
        }


        public static List<Invoice> GetVendorInvoicesDue(int vendorID)
        {
            List<Invoice> invoiceList = new List<Invoice>();
            SqlConnection connection = PayablesDB.GetConnection();
            string selectStatement =
                "SELECT InvoiceNumber, InvoiceDate, InvoiceTotal, " +
                "PaymentTotal, CreditTotal, DueDate " +
                "FROM Invoices " +
                "WHERE VendorID = " + vendorID.ToString() + 
                " AND InvoiceTotal - PaymentTotal - CreditTotal > 0 " +
                "ORDER BY DueDate";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    Invoice invoice = new Invoice();
                    invoice.InvoiceNumber = reader["InvoiceNumber"].ToString();
                    invoice.InvoiceDate = (DateTime)reader["InvoiceDate"];
                    invoice.InvoiceTotal = (decimal)reader["InvoiceTotal"];
                    invoice.PaymentTotal = (decimal)reader["PaymentTotal"];
                    invoice.CreditTotal = (decimal)reader["CreditTotal"];
                    invoice.DueDate = (DateTime)reader["DueDate"];
                    invoiceList.Add(invoice);
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return invoiceList;
        }

        public static decimal GetVendorBalanceDue(int vendorID)
        {
            decimal balanceDue = 0;

            SqlConnection connection = PayablesDB.GetConnection();
            string selectStatement =
                "SELECT SUM(InvoiceTotal - PaymentTotal - CreditTotal) " +
                "AS BalanceDue " +
                "FROM Invoices " +
                "WHERE VendorID = " + vendorID.ToString();
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            try
            {
                connection.Open();
                balanceDue = Convert.ToDecimal(selectCommand.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return balanceDue;

        }
    }
}
