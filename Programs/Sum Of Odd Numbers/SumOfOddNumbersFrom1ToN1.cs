/*
* Output:
  Enter value a number : 100
  Sum of Odd numbers from 1 to 100 is : 2500  
*/

using System;

namespace SumOfOddNumbersFrom1ToN1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.Write("Enter value a number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i += 2)
            {
                sum += i;
            }
            Console.Write($"Sum of Odd numbers from 1 to {number} is : {sum}");
            Console.ReadLine();
        }
    }
}
