using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace PayablesData
{
    public static class VendorDB
    {
        public static List<Vendor> GetVendorsWithBalanceDue()
        {
            List<Vendor> vendorList = new List<Vendor>();
            SqlConnection connection = PayablesDB.GetConnection();
            string selectStatement =
                "SELECT VendorID, Name " +
                "FROM Vendors " +
                "WHERE (SELECT SUM (InvoiceTotal - PaymentTotal " +
                "                 - CreditTotal) " +
                "       FROM Invoices " +
                "       WHERE Invoices.VendorID = Vendors.VendorID) " +
                "     > 0 " +
                "ORDER BY Name";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    Vendor vendor = new Vendor();
                    vendor.VendorID = (int)reader["VendorID"];
                    vendor.Name = reader["Name"].ToString();
                    vendorList.Add(vendor);
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
            return vendorList;
        }

        public static Vendor GetVendorNameAndAddress(int vendorID)
        {
            Vendor vendor = new Vendor();
            SqlConnection connection = PayablesDB.GetConnection();
            string selectStatement =
                "SELECT VendorID, Name, Address1, Address2, " +
                "       City, State, ZipCode " +
                "FROM Vendors " +
                "WHERE VendorID = @VendorID";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@VendorID", vendorID);
            try
            {
                connection.Open();
                SqlDataReader reader =
                    selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (reader.Read())
                {
                    vendor.VendorID = (int)reader["VendorID"];
                    vendor.Name = reader["Name"].ToString();
                    vendor.Address1 = reader["Address1"].ToString();
                    vendor.Address2 = reader["Address2"].ToString();
                    vendor.City = reader["City"].ToString();
                    vendor.State = reader["State"].ToString();
                    vendor.ZipCode = reader["ZipCode"].ToString();
                }
                else
                {
                    vendor = null;
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
            return vendor;
        }
    }
}
