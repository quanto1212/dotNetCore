using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
     public class Account
    {
        public string password { get; set; }
        public string username { get; set; }

        public Account(string username, string password)
        {
            this.username = username;
            this.password = password;
            
        }

        public Account()
        {
        }

        public override string ToString()
        {
            return $"Account: {username} - { password}";
        }

        public override bool Equals(object obj)
        {
            return obj is Account account &&
                   password == account.password &&
                   username == account.username;
        }

       virtual public void Input()
        {
            Console.WriteLine("Username:");
            username = Console.ReadLine();
            Console.WriteLine("Password:");
            password = Console.ReadLine();
        }
        
    }
}
