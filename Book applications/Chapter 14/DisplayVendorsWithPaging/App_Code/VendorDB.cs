using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.ComponentModel;

[DataObject(true)]
public class VendorDB
{
    private static List<Vendor> vendorList;

    [DataObjectMethodAttribute(DataObjectMethodType.Select)]
    public static List<Vendor> GetVendorsByPage(int startIndex, int maxRows)
    {
        vendorList = new List<Vendor>();
        SqlConnection con = new SqlConnection(PayablesDB.GetConnectionString());
        string sel = "SELECT Name, City, State, ZipCode FROM Vendors ORDER BY Name";
        SqlCommand cmd = new SqlCommand(sel, con);
        try
        {
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            Vendor vendor = null;
            while (rdr.Read())
            {
                vendor = new Vendor();
                vendor.Name = rdr["Name"].ToString();
                vendor.City = rdr["City"].ToString();
                vendor.State = rdr["State"].ToString();
                vendor.ZipCode = rdr["ZipCode"].ToString();
                vendorList.Add(vendor);
            }
            rdr.Close();
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            con.Close();
        }

        int rowCount = vendorList.Count;
        if (startIndex + maxRows > rowCount)
        {
            maxRows = rowCount - startIndex;
        }

        List<Vendor> pageList = new List<Vendor>();
        int rowIndex = 0;
        for (int i = 0; i < maxRows; i++)
        {
            rowIndex = i + startIndex;
            pageList.Add(vendorList[rowIndex]);
        }
        return pageList;
    }

    public static int SelectCount()
    {
        return vendorList.Count;
    }
}