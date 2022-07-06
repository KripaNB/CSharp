using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveApproachToPrintNFibonacciNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter the length of the Fibonacci Series:");
            number = Convert.ToInt32(Console.ReadLine());
            FibonacciSeries(0, 1, 1, number);
        }

        public static void FibonacciSeries (int firstNumber, int secondNumber, int counter, int number)
        {
            Console.Write(firstNumber + " ");
            if (counter < number)
            {
                FibonacciSeries(secondNumber, firstNumber + secondNumber, counter + 1, number); 
            }
        }
    }
}
