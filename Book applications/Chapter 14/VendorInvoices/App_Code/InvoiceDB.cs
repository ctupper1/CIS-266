using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;

public class InvoiceDB
{
    [DataObjectMethod(DataObjectMethodType.Select)]
    public static IEnumerable GetInvoicesByVendor(int vendorID)
    {
        SqlConnection con = new SqlConnection(PayablesDB.GetConnectionString());
        string sel = "SELECT InvoiceNumber, InvoiceDate, InvoiceTotal, " + "PaymentTotal, CreditTotal, InvoiceTotal - PaymentTotal " + "- CreditTotal AS BalanceDue, DueDate " + "FROM Invoices " + "WHERE VendorID = @VendorID " + "ORDER BY InvoiceDate";
        SqlCommand cmd = new SqlCommand(sel, con);
        cmd.Parameters.AddWithValue("@VendorID", vendorID);
        SqlDataReader rdr = null;
        try
        {
            con.Open();
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            return rdr;
        }
        catch (Exception ex)
        {
            if (rdr != null)
            {
                rdr.Close();
            }
            else
            {
                con.Close();
            }
            throw ex;
        }
    }
}