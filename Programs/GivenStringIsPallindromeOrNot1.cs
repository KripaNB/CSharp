using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GivenStringIsPallindromeOrNot1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to check Pallindrome:");
            string name = Console.ReadLine();
            string reverse = string.Empty;
            for (int i = name.Length - 1; i >= 0; i--)
            {
                reverse = reverse + name[i];
            }
            if (reverse == name)
                Console.WriteLine(name + " is a Pallindrome.");
            else
                Console.WriteLine(name + " is not a Pallindrome.");
        }
    }
}
