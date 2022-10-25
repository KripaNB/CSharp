/*
 * Output:
   Enter the Nth number of the Fibonacci Series to be printed:
   10
   34
 */

using System;

namespace IterativeApproachToPrintNthFibonacciNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Nth number of the Fibonacci Series to be printed:");
            int NthNumber = Convert.ToInt32(Console.ReadLine());
            NthNumber = NthNumber - 1;
            Console.WriteLine(NthFibonacciNumber(NthNumber));
        }

        public static int NthFibonacciNumber (int number)
        {
            int firstNumber = 0, secondNumber = 1, nextNumber;
            if (number == 0)
                return firstNumber;
            for (int i = 2; i <= number; i++)
            {
                nextNumber = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = nextNumber;
            }
            return secondNumber;
        }
    }
}
