using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    public class Employee: Account
    {
        public string Role { get; set; }
        public double Salary { get; set; }

        
        public Employee(string username, string password, double salary, string role):base(username,password)
        {
          
            Role = role;
            Salary = salary;
        }
        public Employee() { }

        internal void Input()
        {
            Console.WriteLine("Input Employee's info:");
            base.Input();
            Console.WriteLine("Salary:");
            Salary = Double.Parse(Console.ReadLine());
            Console.WriteLine("Role:");
            Role = Console.ReadLine();



        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override string ToString()
        {
            
            return $"Employee:{username} - {password} - {Role} - {Salary}";
        }
    }
}
