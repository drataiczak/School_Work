public class CommissionEmployee2
{
    protected string firstName;
    protected string lastName;
    protected string socialSecurityNumber;
    protected decimal grossSales;
    protected decimal commissionRate;

    public CommissionEmployee2(string first, string last, string ssn, decimal sales, decimal rate)
    {
        firstName = first;
        lastName = last;
        socialSecurityNumber = ssn;
        grossSales = sales;
        commissionRate = rate;
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
            return commissionRate;
        }
        set
        {
            commissionRate = (value > 0 && value < 1) ? value : 0;
        }
    }

    public virtual decimal Earnings()
    {
        return commissionRate * grossSales;
    }

    public override string ToString()
    {
        return string.Format("{0}: {1} {2}\n{3}: {4}\n{5}: {6:C}\n{7}: {8:F2}",
            "commission employee", firstName, lastName,
            "social security number", socialSecurityNumber,
            "gross sales", grossSales, "commission rate", commissionRate);
    }
}