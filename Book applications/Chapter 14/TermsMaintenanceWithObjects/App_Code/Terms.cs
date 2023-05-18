using System;

public class Terms
{
    private int m_termsID;
    private string m_description;
    private int m_dueDays;

    public Terms()
    {

    }

    public int TermsID
    {
        get
        {
            return m_termsID;
        }
        set
        {
            m_termsID = value;
        }
    }

    public string Description
    {
        get
        {
            return m_description;
        }
        set
        {
            m_description = value;
        }
    }

    public int DueDays
    {
        get
        {
            return m_dueDays;
        }
        set
        {
            m_dueDays = value;
        }
    }
  }