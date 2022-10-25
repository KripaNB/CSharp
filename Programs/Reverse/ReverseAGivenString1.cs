/*
 * Output:
   Enter a string:
   Archer
   The Reverse string is: rehcrA
*/

using System;

namespace ReverseAGivenString1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string name = Console.ReadLine();
            string reverse = string.Empty;
            for (int i = name.Length - 1; i >= 0; i--)
            {
                reverse = reverse + name[i];
            }
            Console.WriteLine($"The Reverse string is: {reverse}");
        }
    }
}
