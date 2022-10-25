/*
 * Output:
   Enter a Number: 241234
   The Reverse order is: 432142    
*/

using System;

namespace ReverseAGivenNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number: ");
            int number = int.Parse(Console.ReadLine());
            int reminder, reverse = 0;
            while (number > 0)
            {
                reminder = number % 10;
                reverse = (reverse * 10) + reminder;
                number = number / 10;
            }
            Console.WriteLine($"The Reverse order is: {reverse}");
        }
    }
}
