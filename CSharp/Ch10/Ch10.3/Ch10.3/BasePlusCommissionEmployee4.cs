public class BasePlusCommissionEmployee4: CommissionEmployee3
{
    private decimal baseSalary;

    public BasePlusCommissionEmployee4(string first, string last, string ssn, decimal sales, decimal rate, decimal salary) : base (first, last, ssn, sales, rate)
    {
        baseSalary = salary;
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

    public override decimal Earnings()
    {
        return BaseSalary + base.Earnings();
    }

    public override string ToString()
    {
        return string.Format("{0} {1}\n{2}: {3:C}",
            "base-salaried", base.ToString(), "base salary", BaseSalary);
    }
}