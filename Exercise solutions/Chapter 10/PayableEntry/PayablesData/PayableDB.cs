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
            //  Create a new Command for this function
            SqlCommand insertCommand = new SqlCommand();
            insertCommand.Connection = connection;

            insertCommand.CommandText = "INSERT INTO Invoices " + "(VendorID, InvoiceNumber, InvoiceDate, InvoiceTotal, " + "TermsID, DueDate) " + "VALUES (@VendorID, @InvoiceNumber, @InvoiceDate, @InvoiceTotal, " + "@TermsID, @DueDate)";
            //  Set the Transaction property of this command to the static payableTran transaction
            insertCommand.Transaction = payableTran;

            insertCommand.Parameters.Clear();

            insertCommand.Parameters.AddWithValue("@VendorID", payable.Invoice.VendorID);
            insertCommand.Parameters.AddWithValue("@InvoiceNumber", payable.Invoice.InvoiceNumber);
            insertCommand.Parameters.AddWithValue("@InvoiceDate", payable.Invoice.InvoiceDate);
            insertCommand.Parameters.AddWithValue("@InvoiceTotal", payable.Invoice.InvoiceTotal);
            insertCommand.Parameters.AddWithValue("@TermsID", payable.Invoice.TermsID);
            insertCommand.Parameters.AddWithValue("@DueDate", payable.Invoice.DueDate);

            insertCommand.ExecuteNonQuery();

            //  The following code uses an alternative constructor that allows you to pass the command text in
            //  when you declare and initialize the command object.
            //  This makes for slightly shorter code than the example shown above.
            //  Its use is really only viable if the command text is short, as in this case.
            SqlCommand identCommand = new SqlCommand("SELECT IDENT_CURRENT('Invoices') FROM Invoices", connection);
            //  Set the Transaction property of this command to the static payableTran transaction
            identCommand.Transaction = payableTran;

            int invoiceID = Convert.ToInt32(identCommand.ExecuteScalar());
            return invoiceID;
        }

        private static void InsertLineItem(LineItem li)
        {
            SqlCommand insertliCommand = new SqlCommand();
            insertliCommand.Connection = connection;
            insertliCommand.CommandText = "INSERT INTO InvoiceLineItems " + "(InvoiceID, InvoiceSequence, AccountNo, Description, Amount) " + "VALUES (@InvoiceID, @InvoiceSequence, @AccountNo, " + "@Description, @Amount)";

            insertliCommand.Transaction = payableTran;
            insertliCommand.Parameters.Clear();

            insertliCommand.Parameters.AddWithValue("@InvoiceID", li.InvoiceID);
            insertliCommand.Parameters.AddWithValue("@InvoiceSequence", li.InvoiceSequence);
            insertliCommand.Parameters.AddWithValue("@AccountNo", li.AccountNo);
            insertliCommand.Parameters.AddWithValue("@Description", li.Description);
            insertliCommand.Parameters.AddWithValue("@Amount", li.Amount);

            insertliCommand.ExecuteNonQuery();

        }
    }
}