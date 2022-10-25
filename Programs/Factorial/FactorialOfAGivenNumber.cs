/*
 * Output:
   Enter a Number: 5
   Factorial of 5 is: 120
*/

using System;

namespace FactorialOfAGivenNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number: ");
            int number = int.Parse(Console.ReadLine());
            int factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine($"Factorial of {number} is: {factorial}");
        }
    }
}
