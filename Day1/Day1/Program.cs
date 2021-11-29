using System;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a = new Account("chilp", "123456");
            Console.WriteLine("Account: ");
            Console.WriteLine(a);
            Console.WriteLine();

            Employee e1 = new Employee("trungnb", "123457", 1200.4, "Admin");
            Employee e2 = new Employee();
            Console.WriteLine("Input Employee's info:");
            e2.Input();
            Console.WriteLine($"Employee: {e1}");
            Console.WriteLine($"Employee: {e2}");
            Console.WriteLine();

            Customer c1 = new Customer("trungnb", "123457", "Bao Trung", new DateTime(1987, 12, 1));
            Customer c2 = new Customer();
            Console.WriteLine("Input Customer's info:");
            c2.Input();
            Console.WriteLine($"Customer: {c1}");
            Console.WriteLine($"Customer: {c2}");
            Console.ReadLine();

        }
    }
}
