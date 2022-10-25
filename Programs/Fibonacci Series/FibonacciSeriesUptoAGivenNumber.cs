/*
 * Output:
   Enter a number upto which print the Fibonacci Series:
   13
   0 1 1 2 3 5 8
*/

using System;

namespace FibonacciSeriesUptoAGivenNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 0, secondNumber = 1, nextNumber, number;
            Console.WriteLine("Enter a number upto which print the Fibonacci Series:");
            number = Convert.ToInt32(Console.ReadLine());
            Console.Write(firstNumber + " " + secondNumber + " ");
            nextNumber = firstNumber + secondNumber;
            for (int i = 2; nextNumber < number; i++)
            {
                Console.Write(nextNumber + " ");
                firstNumber = secondNumber;
                secondNumber = nextNumber;
                nextNumber = firstNumber + secondNumber;
            }
        }
    }
}
