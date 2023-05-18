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
        public static Invoice GetInvoice(string invoiceNo)
        {
            Invoice invoice = new Invoice();
            SqlConnection connection = PayablesDB.GetConnection();
            string selectStatement =
                "SELECT InvoiceNumber, InvoiceDate, InvoiceTotal, PaymentTotal " +
                "FROM Invoices " +
                "WHERE InvoiceNumber = @InvoiceNumber";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@InvoiceNumber", invoiceNo);
            try
            {
                connection.Open();
                SqlDataReader reader =
                    selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (reader.Read())
                {
                    invoice.InvoiceNumber = reader["InvoiceNumber"].ToString();
                    invoice.InvoiceDate = (DateTime)reader["InvoiceDate"];
                    invoice.InvoiceTotal = (decimal)reader["InvoiceTotal"];
                    invoice.PaymentTotal = (decimal)reader["PaymentTotal"];
                }
                else
                {
                    invoice = null;
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
            return invoice;
        }

        public static bool TransferPayment(Invoice fromInvoice,
            Invoice toInvoice, decimal payment)
        {
            SqlConnection connection = PayablesDB.GetConnection();
            SqlTransaction paymentTran = null;

            SqlCommand fromCommand = new SqlCommand();
            fromCommand.Connection = connection;
            fromCommand.CommandText =
                "UPDATE Invoices " +
                "SET PaymentTotal = PaymentTotal - @Payment " +
                "WHERE InvoiceNumber = @InvoiceNumber " +
                "  AND PaymentTotal = @PaymentTotal";
            fromCommand.Parameters.AddWithValue("@payment", payment);
            fromCommand.Parameters.AddWithValue("@InvoiceNumber",
                fromInvoice.InvoiceNumber);
            fromCommand.Parameters.AddWithValue("@PaymentTotal",
                fromInvoice.PaymentTotal);

            SqlCommand toCommand = new SqlCommand();
            toCommand.Connection = connection;
            toCommand.CommandText =
                "UPDATE Invoices " +
                "SET PaymentTotal = PaymentTotal + @Payment " +
                "WHERE InvoiceNumber = @InvoiceNumber " +
                "  AND PaymentTotal = @PaymentTotal";
            toCommand.Parameters.AddWithValue("@payment", payment);
            toCommand.Parameters.AddWithValue("@InvoiceNumber",
                toInvoice.InvoiceNumber);
            toCommand.Parameters.AddWithValue("@PaymentTotal",
                toInvoice.PaymentTotal);

            try
            {
                connection.Open();
                paymentTran = connection.BeginTransaction();
                fromCommand.Transaction = paymentTran;
                toCommand.Transaction = paymentTran;

                int count = fromCommand.ExecuteNonQuery();
                if (count > 0)
                {
                    count = toCommand.ExecuteNonQuery();
                    if (count > 0)
                    {
                        paymentTran.Commit();
                        return true;
                    }
                    else
                    {
                        paymentTran.Rollback();
                        return false;
                    }
                }
                else
                {
                    paymentTran.Rollback();
                    return false;
                }
            }
            catch (SqlException ex)
            {
                if (paymentTran != null)
                    paymentTran.Rollback();
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
