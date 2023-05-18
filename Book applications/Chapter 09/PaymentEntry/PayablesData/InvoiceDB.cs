using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace PayablesData
{
    public static class InvoiceDB
    {
        public static List<Invoice> GetUnpaidVendorInvoices(int vendorID)
        {
            List<Invoice> invoiceList = new List<Invoice>();
            SqlConnection connection = PayablesDB.GetConnection();
            string selectStatement =
                "SELECT InvoiceID, VendorID, InvoiceNumber, InvoiceDate, " +
                "       InvoiceTotal, PaymentTotal, CreditTotal, " +
                "       TermsID, DueDate, PaymentDate " +
                "FROM Invoices " +
                "WHERE VendorID = @VendorID " +
                "  AND InvoiceTotal - PaymentTotal - CreditTotal > 0 " +
                "ORDER BY InvoiceDate";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@VendorID", vendorID);

            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    Invoice invoice = new Invoice();
                    invoice.InvoiceID = (int)reader["InvoiceID"];
                    invoice.VendorID = (int)reader["VendorID"];
                    invoice.InvoiceNumber = reader["InvoiceNumber"].ToString();
                    invoice.InvoiceDate = (DateTime)reader["InvoiceDate"];
                    invoice.InvoiceTotal = (decimal)reader["InvoiceTotal"];
                    invoice.PaymentTotal = (decimal)reader["PaymentTotal"];
                    invoice.CreditTotal = (decimal)reader["CreditTotal"];
                    invoice.TermsID = (int)reader["TermsID"];
                    invoice.DueDate = (DateTime)reader["DueDate"];
                    if (reader["PaymentDate"] == DBNull.Value)
                        invoice.PaymentDate = null;
                    else
                        invoice.PaymentDate = (DateTime)reader["PaymentDate"];
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
 
        public static bool UpdatePayment(Invoice oldInvoice,
            Invoice newInvoice)
        {
            SqlConnection connection = PayablesDB.GetConnection();
            string updateStatement =
                "UPDATE Invoices " +
                "SET PaymentTotal = @NewPaymentTotal, " +
                "    PaymentDate = @NewPaymentDate " +
                "WHERE InvoiceID = @OldInvoiceID " +
                "  AND VendorID = @OldVendorID " +
                "  AND InvoiceNumber = @OldInvoiceNumber " +
                "  AND InvoiceDate = @OldInvoiceDate " +
                "  AND InvoiceTotal = @OldInvoiceTotal " +
                "  AND PaymentTotal = @OldPaymentTotal " +
                "  AND CreditTotal = @OldCreditTotal " +
                "  AND TermsID = @OldTermsID " +
                "  AND DueDate = @OldDueDate " +
                "  AND (PaymentDate = @OldPaymentDate " +
                "   OR PaymentDate IS NULL AND @OldPaymentDate IS NULL)";
            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);
            updateCommand.Parameters.AddWithValue("@NewPaymentTotal", 
                newInvoice.PaymentTotal);
            updateCommand.Parameters.AddWithValue("@NewPaymentDate", 
                newInvoice.PaymentDate);
            updateCommand.Parameters.AddWithValue("@OldInvoiceID", 
                oldInvoice.InvoiceID);
            updateCommand.Parameters.AddWithValue("@OldVendorID", 
                oldInvoice.VendorID);
            updateCommand.Parameters.AddWithValue("@OldInvoiceNumber",
                oldInvoice.InvoiceNumber);
            updateCommand.Parameters.AddWithValue("@OldInvoiceDate",
                oldInvoice.InvoiceDate);
            updateCommand.Parameters.AddWithValue("@OldInvoiceTotal",
                oldInvoice.InvoiceTotal);
            updateCommand.Parameters.AddWithValue("@OldPaymentTotal",
                oldInvoice.PaymentTotal);
            updateCommand.Parameters.AddWithValue("@OldCreditTotal", 
                oldInvoice.CreditTotal);
            updateCommand.Parameters.AddWithValue("@OldTermsID", 
                oldInvoice.TermsID);
            updateCommand.Parameters.AddWithValue("@OldDueDate", 
                oldInvoice.DueDate);
            if (!oldInvoice.PaymentDate.HasValue)
                updateCommand.Parameters.AddWithValue("@OldPaymentDate", 
                    DBNull.Value);
            else
                updateCommand.Parameters.AddWithValue("@OldPaymentDate", 
                    oldInvoice.PaymentDate);

            try
            {
                connection.Open();

                int count = updateCommand.ExecuteNonQuery();
                if (count > 0)
                    return true;
                else
                    return false;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
