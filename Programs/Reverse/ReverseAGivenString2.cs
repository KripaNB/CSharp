/*
 * Output:
   Enter a string:
   Archer
   The Reverse string is: rehcrA
*/
using System;


namespace ReverseAGivenString2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string name = Console.ReadLine();
            string reverse = string.Empty;
            foreach (char c in name)
            {
                reverse = c + reverse;
            }
            Console.WriteLine($"The Reverse string is: {reverse}");
        }
    }
}
