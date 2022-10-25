/*
 * Output:
   Enter a number to check Pallindrome:
   2112
   The number 2112 is a Pallindrome. 
*/

using System;

namespace GivenNumberIsPallindromeOrNot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int remainder, sum = 0;
            Console.WriteLine("Enter a number to check Pallindrome:");
            int number = Convert.ToInt32(Console.ReadLine());
            int temp = number;
            while (number > 0)
            {
                remainder = number % 10;
                sum = (sum * 10) + remainder;
                number = number / 10;
            }
            if(temp == sum)
                Console.WriteLine("The number " + temp + " is a Pallindrome.");
            else
                Console.WriteLine("The number " + temp + " is not a Pallindrome.");
        }
    }
}
