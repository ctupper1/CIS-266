using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace PayablesData
{
    public static class PayableDB
    {
        private static SqlConnection connection;
        private static SqlCommand payableCommand;
        private static SqlTransaction payableTran;

        public static int WritePayable(Payable payable)
        {
            try
            {
                connection = PayablesDB.GetConnection();
                connection.Open();
                payableTran = connection.BeginTransaction();

                payableCommand = new SqlCommand();
                payableCommand.Connection = connection;
                payableCommand.Transaction = payableTran;

                int invoiceID = InsertInvoice(payable);
                int invoiceSequence = 0;
                foreach (LineItem li in payable.LineItems)
                {
                    li.InvoiceID = invoiceID;
                    invoiceSequence += 1;
                    li.InvoiceSequence = invoiceSequence;
                    InsertLineItem(li);
                }
                payableTran.Commit();
                return invoiceID;
            }
            catch (SqlException ex)
            {
                payableTran.Rollback();
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        private static int InsertInvoice(Payable payable)
        {
            payableCommand.CommandText =
                "INSERT INTO Invoices " +
                "(VendorID, InvoiceNumber, InvoiceDate, InvoiceTotal, " +
                "TermsID, DueDate) " +
                "VALUES (@VendorID, @InvoiceNumber, @InvoiceDate, " +
                "@InvoiceTotal, @TermsID, @DueDate)";
            payableCommand.Parameters.Clear();

            payableCommand.Parameters.AddWithValue("@VendorID",
                payable.Invoice.VendorID);
            payableCommand.Parameters.AddWithValue("@InvoiceNumber",
                payable.Invoice.InvoiceNumber);
            payableCommand.Parameters.AddWithValue("@InvoiceDate",
                payable.Invoice.InvoiceDate);
            payableCommand.Parameters.AddWithValue("@InvoiceTotal",
                payable.Invoice.InvoiceTotal);
            payableCommand.Parameters.AddWithValue("@TermsID",
                payable.Invoice.TermsID);
            payableCommand.Parameters.AddWithValue("@DueDate",
                payable.Invoice.DueDate);

            payableCommand.ExecuteNonQuery();

            payableCommand.CommandText =
                "SELECT IDENT_CURRENT('Invoices') FROM Invoices";
            int invoiceID = Convert.ToInt32(payableCommand.ExecuteScalar());
            return invoiceID;
        }

        private static void InsertLineItem(LineItem li)
        {
            payableCommand.CommandText =
                "INSERT INTO InvoiceLineItems " +
                "(InvoiceID, InvoiceSequence, AccountNo, Description, Amount) " +
                "VALUES (@InvoiceID, @InvoiceSequence, @AccountNo, " +
                "@Description, @Amount)";
            payableCommand.Parameters.Clear();

            payableCommand.Parameters.AddWithValue("@InvoiceID", li.InvoiceID);
            payableCommand.Parameters.AddWithValue("@InvoiceSequence",
                li.InvoiceSequence);
            payableCommand.Parameters.AddWithValue("@AccountNo", li.AccountNo);
            payableCommand.Parameters.AddWithValue("@Description", 
                li.Description);
            payableCommand.Parameters.AddWithValue("@Amount", li.Amount);

            payableCommand.ExecuteNonQuery();
        }
    }
}
