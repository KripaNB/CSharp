/*
* Output:
  Enter value a number : 100
  Sum of even numbers from 1 to 100 is : 2550 
*/

using System;

namespace SumOfEvenNumbersFrom1ToN2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.Write("Enter value a number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= number; i += 2)
            {
                sum += i;
            }
            Console.Write($"Sum of even numbers from 1 to {number} is : {sum}");
            Console.ReadLine();
        }
    }
}
