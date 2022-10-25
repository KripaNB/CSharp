/*
 * Output:
   Enter the number of elements to print:
   10
   0 1 1 2 3 5 8 13 21 34
*/

using System;

namespace IterativeApproachToPrintNFibonacciNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 0, secondNumber = 1, nextNumber, numberOfElements;
            Console.WriteLine("Enter the number of elements to print:");
            numberOfElements = Convert.ToInt32(Console.ReadLine());
            if (numberOfElements < 2)
            {
                Console.WriteLine("Enter a number greater than 2.");
            }
            else
            {
                Console.Write(firstNumber + " " + secondNumber + " ");
                for (int i = 2; i < numberOfElements; i++)
                {
                    nextNumber = firstNumber + secondNumber;
                    Console.Write(nextNumber + " ");
                    firstNumber = secondNumber;
                    secondNumber = nextNumber;
                }
            }

        }
    }
}
