/*
* Output:
  Enter value a number : 60
  Sum of even numbers from 1 to 60 is : 930   
*/

using System;

namespace SumOfEvenNumbersFrom1ToN1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, i = 2;
            Console.Write("Enter value a number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            while (i <= number)
            {
                sum += i;
                i += 2;
            }
            Console.Write($"Sum of even numbers from 1 to {number} is : {sum}");
            Console.ReadLine();
        }
    }
}
