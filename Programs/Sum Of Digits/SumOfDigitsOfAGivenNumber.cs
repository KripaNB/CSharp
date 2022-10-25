/*
 * Output:
   Enter the Number: 35
   The Sum of Digits is: 8 
*/

using System;

namespace SumOfDigitsOfAGivenNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Number: ");
            int number = int.Parse(Console.ReadLine());
            int sum = 0, reminder;
            while (number > 0)
            {
                reminder = number % 10;
                sum = sum + reminder;
                number = number / 10;
            }
            Console.WriteLine($"The Sum of Digits is: {sum}");
        }
    }
}
