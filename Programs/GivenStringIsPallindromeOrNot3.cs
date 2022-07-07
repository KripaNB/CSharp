using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GivenStringIsPallindromeOrNot3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to check Pallindrome:");
            string name = Console.ReadLine();
            char[] nameArray = name.ToCharArray();
            Array.Reverse(nameArray);
            string reverse = new string(nameArray);
            if (name.Equals(reverse))
                Console.WriteLine(name + " is a Pallindrome.");
            else
                Console.WriteLine(name + " is not a Pallindrome.");
        }
    }
}
