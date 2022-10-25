/*
 * Output:
   Enter a string to check Pallindrome:
   historic
   historic is not a Pallindrome.
*/
using System;

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
