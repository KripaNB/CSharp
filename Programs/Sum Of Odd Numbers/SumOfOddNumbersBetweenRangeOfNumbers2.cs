/*
* Output1:
 Enter From Number : 45
 Enter To Number : 76
 Sum of Odd numbers from 45 to 76 is : 960   

 Output2:
 Enter From Number : 45
 Enter To Number : 25
 Invalid From and To Numbers
*/

using System;

namespace SumOfOddNumbersBetweenRangeOfNumbers2
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
                sum = FindSumOfOddNumbers(sum, FromNumber, ToNumber);
                Console.Write($"Sum of Odd numbers from {FromNumber} to {ToNumber} is : {sum}");
            }
            else
            {
                Console.Write("Invalid From and To Numbers");
            }
            Console.ReadLine();
        }

        private static int FindSumOfOddNumbers(int sum, int FromNumber, int ToNumber)
        {
            for (int i = FromNumber; i <= ToNumber; i++)
            {
                if (i % 2 == 1)
                    sum += i;
            }
            return sum;
        }
    }
}
