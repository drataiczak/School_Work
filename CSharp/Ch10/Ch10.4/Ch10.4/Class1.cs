using System;

public class ConstructorTest
{
    public static void Main(string[] args)
    {
        CommissionEmployee4 employee1 = new CommissionEmployee4("Bob", "Lewis", "333-33-3333", 50000.00M, .04M);
        Console.WriteLine();

        BasePlusCommissionEmployee5 employee2 = new BasePlusCommissionEmployee5("Lisa", "Jones", "555-55-5555", 2000.00M, .06M, 800.00M);
        Console.WriteLine();

        BasePlusCommissionEmployee5 employee3 = new BasePlusCommissionEmployee5("Mark", "Sands", "888-88-8888", 8000.00M, .15M, 20000.00M);
        Console.ReadKey();
    }
}