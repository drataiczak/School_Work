using System;

public class BasePlusCommissionEmployee5: CommissionEmployee4
{
    private decimal baseSalary;

    public BasePlusCommissionEmployee5(string first, string last, string ssn, decimal sales, decimal rate, decimal salary) : base(first, last, ssn, sales, rate)
    {
        baseSalary = salary;
        Console.WriteLine("\nBasePlusCommissionEmployee5 constructor:\n" + this);
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