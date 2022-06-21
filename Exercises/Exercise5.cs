/* Write a program to count how many numbers between 1 and 100are divisible by 3 with no remainders.
 * Display the count on the console. */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 1;
            int count = 0;
            while (number <= 100)
            {
                if (number % 3 == 0)
                    count++;
                number++;
            }
            Console.WriteLine(count);
        }
    }
}
