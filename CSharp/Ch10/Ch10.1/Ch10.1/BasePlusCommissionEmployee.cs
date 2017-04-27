public class BasePlusCommissionEmployee
{
    private string firstName;
    private string lastName;
    private string socialSecurityNumber;
    private decimal grossSales;
    private decimal commissionRate;
    private decimal baseSalary;

    public BasePlusCommissionEmployee(string first, string last, string ssn, decimal sales, decimal rate, decimal salary)
    {
        firstName = first;
        lastName = last;
        socialSecurityNumber = ssn;
        grossSales = sales;
        commissionRate = rate;
        baseSalary = salary;
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

    public decimal BaseSalary
    {
        get
        {
            return baseSalary;
        }
        set
        {
            baseSalary = (value < 0) ? 0 : value;
        }
    }

    public decimal Earnings()
    {
        return BaseSalary + (CommissionRate * GrossSales);
    }

    public override string ToString()
    {
        return string.Format(
           "{0}: {1} {2}\n{3}: {4}\n{5}: {6:C}\n{7}: {8:F2}\n{9}: {10:C}",
           "base-salaried commission employee", FirstName, LastName,
           "social security number", SocialSecurityNumber,
           "gross sales", GrossSales, "commission rate", CommissionRate,
           "base salary", BaseSalary);
    }
}
