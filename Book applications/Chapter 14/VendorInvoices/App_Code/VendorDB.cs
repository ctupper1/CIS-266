using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;

[DataObject(true)]
public class VendorDB
{
    [DataObjectMethod(DataObjectMethodType.Select)]
    public static IEnumerable GetVendorList()
    {
        SqlConnection con = new SqlConnection(PayablesDB.GetConnectionString());
        string sel = "SELECT VendorID, Name FROM Vendors ORDER BY Name";
        SqlCommand cmd = new SqlCommand(sel, con);
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