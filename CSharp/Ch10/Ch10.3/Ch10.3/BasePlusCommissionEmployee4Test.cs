﻿using System;

public class BasePlusCommissionEmployeeTest4
{
    public static void Main(string[] args)
    {
        BasePlusCommissionEmployee4 employee = new BasePlusCommissionEmployee4("Bob", "Lewis", "333-33-3333", 5000.00M, .04M, 300.00M);

        Console.WriteLine("Employee information obtained by properties and methods: \n");
        Console.WriteLine("{0} {1}", "First name is", employee.FirstName);
        Console.WriteLine("{0} {1}", "Last name is", employee.LastName);
        Console.WriteLine("{0} {1}", "Social security number is", employee.SocialSecurityNumber);
        Console.WriteLine("{0} {1:C}", "Gross sales are", employee.GrossSales);
        Console.WriteLine("{0} {1:F2}", "Commission rate is", employee.CommissionRate);
        Console.WriteLine("{0} {1:C}", "Earnings are", employee.Earnings());
        Console.WriteLine("{0} {1:C}", "Base salary is", employee.BaseSalary);

        employee.BaseSalary = 10000.00M;
        Console.WriteLine("\n{0}:\n\n{1}", "Updated employee information optained by ToString", employee);
        Console.WriteLine("earnings: {0:C}", employee.Earnings());
        Console.ReadKey();
    }
}