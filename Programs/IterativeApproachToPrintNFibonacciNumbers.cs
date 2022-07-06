using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
