using System;

public class BasePlusCommissionEmployeeTest3
{
    public static void Main(string[] args)
    {
        BasePlusCommissionEmployee3 basePlusCommissionEmployee = new BasePlusCommissionEmployee3("Bob", "Lewis", "333-33-3333", 5000.00M, .04M, 300.00M);

        Console.WriteLine("Employee information obtained by properties and methods: \n");
        Console.WriteLine("{0} {1}", "First name is", basePlusCommissionEmployee.FirstName);
        Console.WriteLine("{0} {1}", "Last name is", basePlusCommissionEmployee.LastName);
        Console.WriteLine("{0} {1}", "Social security number is", basePlusCommissionEmployee.SocialSecurityNumber);
        Console.WriteLine("{0} {1:C}", "Gross sales are", basePlusCommissionEmployee.GrossSales);
        Console.WriteLine("{0} {1:F2}", "Commission rate is", basePlusCommissionEmployee.CommissionRate);
        Console.WriteLine("{0} {1:C}", "Earnings are", basePlusCommissionEmployee.Earnings());
        Console.WriteLine("{0} {1:C}", "Base salary is", basePlusCommissionEmployee.BaseSalary);

        basePlusCommissionEmployee.BaseSalary = 1000.00M;
        Console.WriteLine("\n{0}:\n\n{1}", "Updated employee information obtained by ToString", basePlusCommissionEmployee);
        Console.WriteLine("earnings: {0:C}", basePlusCommissionEmployee.Earnings());
        Console.ReadKey();
    }
}