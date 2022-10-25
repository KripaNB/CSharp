/*
 * Output:
   Enter a Number: 8
   Factorial is: 40320
*/
using System;

namespace FactorialOfAGivenNumberUsingWhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number: ");
            int number = int.Parse(Console.ReadLine());
            long factorial = 1;
            while (number != 1)
            {
                factorial = factorial * number;
                number = number - 1;
            }

            Console.WriteLine($"Factorial is: {factorial}");
        }
    }
}
