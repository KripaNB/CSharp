/*
 * Output:
   Enter the Nth number of the Fibonacci Series:
   10
   34
*/

using System;

namespace RecursiveApproachToPrintNthFibonacciNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Nth number of the Fibonacci Series:");
            int NthNumber = Convert.ToInt32(Console.ReadLine());
            NthNumber = NthNumber - 1;
            Console.WriteLine(NthFibonacciNumber(NthNumber));
        }
        
        public static int NthFibonacciNumber(int number)
        {
            if (number == 0 || number == 1)
                return number;
            else
            {
                return NthFibonacciNumber(number - 1) + NthFibonacciNumber(number - 2);
            }
        }
    }
}
