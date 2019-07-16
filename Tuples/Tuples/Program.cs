using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            (string First, string Last) name = GetName();
            System.Console.WriteLine($"Hello { name.First } { name.Last }!");
        }

        static (string First, string Last) GetName()
        {
            string firstName, lastName;
            firstName = GetUserInput("Please enter first name");
            lastName = GetUserInput("Please enter last name");

            return (firstName, lastName);
        }

        private string GetUserInput(string name)
        {
            System.Console.Write(name);
            return System.Console.ReadLine();
        }
    }
}
