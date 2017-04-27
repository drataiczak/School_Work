using System;

public class CommissionEmployeeTest
{
    public static void Main(string[] args)
    {
        CommissionEmployee employee = new CommissionEmployee("Sue", "Jones", "222-22-222", 10000.00M, .06M);

        Console.WriteLine("Employee information obtained by properties and methods: \n");
        Console.WriteLine("{0} {1}", "First name is", employee.FirstName);
        Console.WriteLine("{0} {1}", "Last name is", employee.LastName);
        Console.WriteLine("{0} {1}", "Social security number is", employee.SocialSecurityNumber);
        Console.WriteLine("{0} {1}", "Gross sales are", employee.GrossSales);
        Console.WriteLine("{0} {1}", "Commission rate is", employee.CommissionRate);
        Console.WriteLine("{0} {1}", "Earnings are", employee.Earnings());

        employee.GrossSales = 5000.00M;
        employee.CommissionRate = .1M;

        Console.WriteLine("\n{0}:\n\n{1}", "Updated employee information obtained by ToString", employee);
        Console.WriteLine("earnings: {0:C}", employee.Earnings());
        Console.ReadKey();
    }
}
