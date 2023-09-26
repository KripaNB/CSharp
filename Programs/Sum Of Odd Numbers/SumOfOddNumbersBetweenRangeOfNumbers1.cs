/*
* Output:
  Enter From Number : 50
  Enter To Number : 100
  Sum of Odd numbers from 50 to 100 is : 1875 
*/

using System;

namespace SumOfOddNumbersBetweenRangeOfNumbers1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.Write("Enter From Number : ");
            int FromNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter To Number : ");
            int ToNumber = Convert.ToInt32(Console.ReadLine());
            if (FromNumber < ToNumber)
            {
                for (int i = FromNumber; i <= ToNumber; i++)
                {
                    if (i % 2 == 1)
                        sum += i;
                }
                Console.Write($"Sum of Odd numbers from {FromNumber} to {ToNumber} is : {sum}");
            }
            else
            {
                Console.Write("Invalid From and To Numbers");
            }
            Console.ReadLine();
        }
    }
}
