using System;

public class Vendor
{
    private int m_VendorID;
    private string m_Name;
    private string m_Address1;
    private string m_Address2;
    private string m_City;
    private string m_State;
    private string m_ZipCode;
    private string m_Phone;
    private string m_ContactLName;
    private string m_ContactFName;
    private int m_DefaultTermsID;
    private int m_DefaultAccountNo;

    public Vendor()
    {

    }

    public int VendorID
    {
        get
        {
            return m_VendorID;
        }
        set
        {
            m_VendorID = value;
        }
    }

    public string Name
    {
        get
        {
            return m_Name;
        }
        set
        {
            m_Name = value;
        }
    }

    public string Address1
    {
        get
        {
            return m_Address1;
        }
        set
        {
            m_Address1 = value;
        }
    }

    public string Address2
    {
        get
        {
            return m_Address2;
        }
        set
        {
            m_Address2 = value;
        }
    }

    public string City
    {
        get
        {
            return m_City;
        }
        set
        {
            m_City = value;
        }
    }

    public string State
    {
        get
        {
            return m_State;
        }
        set
        {
            m_State = value;
        }
    }

    public string ZipCode
    {
        get
        {
            return m_ZipCode;
        }
        set
        {
            m_ZipCode = value;
        }
    }

    public string Phone
    {
        get
        {
            return m_Phone;
        }
        set
        {
            m_Phone = value;
        }
    }

    public string ContactLName
    {
        get
        {
            return m_ContactLName;
        }
        set
        {
            m_ContactLName = value;
        }
    }

    public string ContactFName
    {
        get
        {
            return m_ContactFName;
        }
        set
        {
            m_ContactFName = value;
        }
    }

    public int DefaultTermsID
    {
        get
        {
            return m_DefaultTermsID;
        }
        set
        {
            m_DefaultTermsID = value;
        }
    }

    public int DefaultAccountNo
    {
        get
        {
            return m_DefaultAccountNo;
        }
        set
        {
            m_DefaultAccountNo = value;
        }
    }

}