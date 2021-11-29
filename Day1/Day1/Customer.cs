using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    public class Customer : Account
    {
        public DateTime DOB { get; set; }
        public string Name { get; set; }

        public Customer(string username, string password, string name, DateTime dOB) : base(username, password)
        {
            DOB = dOB;
            Name = name;
        }

        public Customer()
        {
        }

        public override string ToString()
        {
            return $"Customer:{username} - {password} - {Name} - {DOB} ";
        }

        internal void Input()
        {
            base.Input();
            Console.WriteLine("Name");
            Name = Console.ReadLine();
            Console.WriteLine("DOB:");
            
            DOB = DateTime.Parse(Console.ReadLine());

        }
    }
}
