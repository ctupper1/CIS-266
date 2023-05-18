using System;
using System.Configuration;

public class PayablesDB
{
    public static string GetConnectionString()
    {
        return ConfigurationManager.ConnectionStrings["PayablesConnectionString"].ConnectionString;
    }
}