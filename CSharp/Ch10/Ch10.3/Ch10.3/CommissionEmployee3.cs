public class CommissionEmployee3
{
    private string firstName;
    private string lastName;
    private string socialSecurityNumber;
    private decimal grossSales;
    private decimal commissionsRate;

    public CommissionEmployee3(string first, string last, string ssn, decimal sales, decimal rate)
    {
        firstName = first;
        lastName = last;
        socialSecurityNumber = ssn;
        grossSales = sales;
        commissionsRate = rate;
    }

    public string FirstName
    {
        get
        {
            return firstName;
        }
    }
    
    public string LastName
    {
        get
        {
            return lastName;
        }
    }

    public string SocialSecurityNumber
    {
        get
        {
            return socialSecurityNumber;
        }
    }

    public decimal GrossSales
    {
        get
        {
            return grossSales;
        }
        set
        {
            grossSales = (value < 0) ? 0 : value;
        }
    }

    public decimal CommissionRate
    {
        get
        {
            return commissionsRate;
        }
        set
        {
            commissionsRate = (value > 0 && value < 1) ? value : 0;
        }
    }

    public virtual decimal Earnings()
    {
        return CommissionRate * GrossSales;
    }

    public override string ToString()
    {
        return string.Format("{0}: {1} {2}\n{3}: {4}\n{5}: {6:C}\n{7}: {8:F2}",
            "commission employee", FirstName, LastName,
            "social security number", SocialSecurityNumber,
            "gross sales", GrossSales, "commission rate", CommissionRate);
    }
}