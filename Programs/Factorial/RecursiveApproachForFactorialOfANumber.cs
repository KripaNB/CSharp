/*
 * Output:
   Enter a Number : 5
   Factorial of 5 is: 120 
*/

using System;

namespace RecursiveApproachForFactorialOfANumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number: ");
            int number = int.Parse(Console.ReadLine());
            long factorial = RecursiveFactorial(number);
            Console.Write($"Factorial of {number} is: {factorial}");

            Console.ReadLine();
        }

        static long RecursiveFactorial(int number)
        {
            if (number == 1)
            {
                return 1;
            }
            else
            {
                return number * RecursiveFactorial(number - 1);
            }
        }
    }
}
