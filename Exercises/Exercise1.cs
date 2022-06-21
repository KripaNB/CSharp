/* Write a program and ask the user to enter a number. The number should be between 1 and 10. 
 * If the user enters a valid number, display "Valid" on the console. Otherwise, display "Invalid" */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string value;
            int number;
            Console.WriteLine("Enter a number:");
            value = Console.ReadLine();
            number = Convert.ToInt32(value);
            if(number >= 1 && number <=10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
