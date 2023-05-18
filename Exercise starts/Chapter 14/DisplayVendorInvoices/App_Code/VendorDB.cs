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
     
    } 
}