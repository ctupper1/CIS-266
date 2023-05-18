using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

[DataObject(true)]
public class TermsDB
{

    [DataObjectMethod(DataObjectMethodType.Select)]
    public static IEnumerable GetTerms()
    {
        SqlConnection con = new SqlConnection(PayablesDB.GetConnectionString());
        string sel = "SELECT TermsID, Description, DueDays FROM Terms";
        SqlCommand cmd = new SqlCommand(sel, con);
        SqlDataReader rdr = null;
        try
        {
            con.Open();
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            return rdr;
        }
        catch (SqlException ex)
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

    [DataObjectMethod(DataObjectMethodType.Insert)]
    public static void InsertTerms(string description, int dueDays)
    {
        SqlConnection con = new SqlConnection(PayablesDB.GetConnectionString());
        string ins = "INSERT INTO Terms " + "(Description, DueDays) " + "VALUES(@Description, @DueDays)";
        SqlCommand cmd = new SqlCommand(ins, con);
        cmd.Parameters.AddWithValue("Description", description);
        cmd.Parameters.AddWithValue("DueDays", dueDays);
        try
        {
            con.Open();
            cmd.ExecuteNonQuery();
        }
        catch (SqlException ex)
        {
            throw ex;
        }
        finally
        {
            con.Close();
        }
    }

    [DataObjectMethod(DataObjectMethodType.Delete)]
    public static int DeleteTerms(int original_TermsID, string original_Description, int original_DueDays)
    {
        SqlConnection con = new SqlConnection(PayablesDB.GetConnectionString());
        string del = "DELETE FROM Terms " + "WHERE TermsID = @original_TermsID " + "  AND Description = @original_Description " + "  AND DueDays = @original_DueDays";
        SqlCommand cmd = new SqlCommand(del, con);
        cmd.Parameters.AddWithValue("original_TermsID", original_TermsID);
        cmd.Parameters.AddWithValue("original_Description", original_Description);
        cmd.Parameters.AddWithValue("original_DueDays", original_DueDays);
        try
        {
            con.Open();
            int i = cmd.ExecuteNonQuery();
            return i;
        }
        catch (SqlException ex)
        {
            throw ex;
        }
        finally
        {
            con.Close();
        }
    }

    [DataObjectMethod(DataObjectMethodType.Update)]
    public static int UpdateTerms(string description, int dueDays, int original_TermsID, string original_Description, int original_DueDays)
    {
        SqlConnection con = new SqlConnection(PayablesDB.GetConnectionString());
        string up = "UPDATE Terms " + "SET Description = @Description, " + "    DueDays = @DueDays " + "WHERE TermsID = @original_TermsID " + "  AND Description = @original_Description " + "  AND DueDays = @original_DueDays";
        SqlCommand cmd = new SqlCommand(up, con);
        cmd.Parameters.AddWithValue("Description", description);
        cmd.Parameters.AddWithValue("DueDays", dueDays);
        cmd.Parameters.AddWithValue("original_TermsID", original_TermsID);
        cmd.Parameters.AddWithValue("original_Description", original_Description);
        cmd.Parameters.AddWithValue("original_DueDays", original_DueDays);
        try
        {
            con.Open();
            int i = cmd.ExecuteNonQuery();
            return i;
        }
        catch (SqlException ex)
        {
            throw ex;
        }
        finally
        {  con.Close();          }
    }


}