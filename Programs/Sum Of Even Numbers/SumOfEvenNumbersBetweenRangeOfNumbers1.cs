/*
* Output:
  Enter From Number : 20
  Enter To Number : 60
  Sum of even numbers from 20 to 60 is : 840   
*/

using System;

namespace SumOfEvenNumbersBetweenRangeOfNumbers1
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
                    if (i % 2 == 0)
                        sum += i;
                }
                Console.Write($"Sum of even numbers from {FromNumber} to {ToNumber} is : {sum}");
            }
            else
            {
                Console.Write("Invalid From and To Numbers");
            }
            Console.ReadLine();
        }
    }
}
