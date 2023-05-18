using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;

[DataObject(true)]
public class TermsDB
{
    [DataObjectMethod(DataObjectMethodType.Select)]
    public static List<Terms> GetTerms()
    {
        List<Terms> termsList = new List<Terms>();
        SqlConnection con = new SqlConnection(PayablesDB.GetConnectionString());
        string sel = "SELECT TermsID, Description, DueDays FROM Terms";
        SqlCommand cmd = new SqlCommand(sel, con);
        try
        {
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            Terms terms = null;
            while (rdr.Read())
            {
                terms = new Terms();
                terms.TermsID = Convert.ToInt32(rdr["TermsID"]);
                terms.Description = rdr["Description"].ToString();
                terms.DueDays = Convert.ToInt32(rdr["DueDays"]);
                termsList.Add(terms);
            }
            rdr.Close();
        }
        catch (SqlException ex)
        {      throw ex;      }
        finally
        {      con.Close();   }
        return termsList;
    }

    [DataObjectMethod(DataObjectMethodType.Insert)]
    public static void InsertTerms(Terms terms)
    {
        SqlConnection con = new SqlConnection(PayablesDB.GetConnectionString());
        string ins = "INSERT INTO Terms " + "(Description, DueDays) " + "VALUES(@Description, @DueDays)";
        SqlCommand cmd = new SqlCommand(ins, con);
        cmd.Parameters.AddWithValue("Description", terms.Description);
        cmd.Parameters.AddWithValue("DueDays", terms.DueDays);
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
    public static int DeleteTerms(Terms terms)
    {
        SqlConnection con = new SqlConnection(PayablesDB.GetConnectionString());
        string del = "DELETE FROM Terms " + "WHERE TermsID = @TermsID " + "  AND Description = @Description " + "  AND DueDays = @DueDays";
        SqlCommand cmd = new SqlCommand(del, con);
        cmd.Parameters.AddWithValue("TermsID", terms.TermsID);
        cmd.Parameters.AddWithValue("Description", terms.Description);
        cmd.Parameters.AddWithValue("DueDays", terms.DueDays);
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
    public static int UpdateTerms(Terms original_Terms, Terms terms)
    {
        SqlConnection con = new SqlConnection(PayablesDB.GetConnectionString());
        string up = "UPDATE Terms " + "SET Description = @Description, " + "    DueDays = @DueDays " + "WHERE TermsID = @original_TermsID " + "  AND Description = @original_Description " + "  AND DueDays = @original_DueDays";
        SqlCommand cmd = new SqlCommand(up, con);
        cmd.Parameters.AddWithValue("Description", terms.Description);
        cmd.Parameters.AddWithValue("DueDays", terms.DueDays);
        cmd.Parameters.AddWithValue("original_TermsID", original_Terms.TermsID);
        cmd.Parameters.AddWithValue("original_Description", original_Terms.Description);
        cmd.Parameters.AddWithValue("original_DueDays", original_Terms.DueDays);
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
}