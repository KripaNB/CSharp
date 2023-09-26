/*
* Output:
  Enter value a number : 55
  Sum of Odd numbers from 1 to 55 is : 784 
*/

using System;

namespace SumOfOddNumbersFrom1ToN2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, i = 1;
            Console.Write("Enter value a number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            while (i <= number)
            {
                sum += i;
                i += 2;
            }
            Console.Write($"Sum of Odd numbers from 1 to {number} is : {sum}");
            Console.ReadLine();
        }
    }
}
