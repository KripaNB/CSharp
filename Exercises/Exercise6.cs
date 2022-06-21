/* Write a program and continuously ask the user to enter a number or "OK" to exit. Calculate the sum of all the
 * previously entered numbers and display it on the console. */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            while(true)
            {
                Console.Write("Enter a number:");
                string input = Console.ReadLine();
                if (input == "ok")
                    break;
                var numbers = Convert.ToInt32(input);
                total = total + numbers;
            }
            Console.WriteLine("Total count = " + total);
        }
    }
}
