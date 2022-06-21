/* Write a program and ask the user to enter a number. Compute the factorial of the number and print it on 
 * the console. */


using System;

namespace Exercise7
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to calculate the factorial:");
            var number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}! = {1}", number, Factorial(number));
        }

        private static int Factorial(int number)
        {
            if (number == 0 || number == 1)
                return 1;
            return number * Factorial(number - 1);
        }
    }
}