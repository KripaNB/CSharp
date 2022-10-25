/*
 * Output:
   Enter a string:
   Archer
   The Reverse string is: rehcrA
*/
using System;

namespace ReverseAGivenString3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string name = Console.ReadLine();
            char[] nameArray = name.ToCharArray();
            Array.Reverse(nameArray);
            string reverse = new string(nameArray);
            Console.WriteLine($"The Reverse string is: {reverse}");
        }
    }
}
