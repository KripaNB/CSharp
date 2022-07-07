using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GivenStringIsPallindromeOrNot2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to check Pallindrome:");
            string name = Console.ReadLine();
            string reverse = string.Empty;
            foreach(char c in name)
            {
                reverse = c + reverse;
            }
            if (name.Equals(reverse))
                Console.WriteLine(name + " is a Pallindrome.");
            else
                Console.WriteLine(name + " is not a Pallindrome.");
        }
    }
}
