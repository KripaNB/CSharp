/*
* Output1:
  Enter From Number : 21
  Enter To Number : 51
  Sum of even numbers from 21 to 51 is : 540   

  Output1:
  Enter From Number : 25
  Enter To Number : 15
  Invalid From and To Numbers
*/

using System;

namespace SumOfEvenNumbersBetweenRangeOfNumbers2
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
                sum = FindSumOfEvenNumbers(sum, FromNumber, ToNumber);
                Console.Write($"Sum of even numbers from {FromNumber} to {ToNumber} is : {sum}");
            }
            else
            {
                Console.Write("Invalid From and To Numbers");
            }
            Console.ReadLine();
        }

        private static int FindSumOfEvenNumbers(int sum, int FromNumber, int ToNumber)
        {
            for (int i = FromNumber; i <= ToNumber; i++)
            {
                if (i % 2 == 0)
                    sum += i;
            }
            return sum;
        }
    }
}
