/* Write a program and ask the user to enter a time value in the 24-hour time format (Eg: 19:00). A valid time should 
 * be between 00:00 and 23:59. If the time is valid, display "OK". Otherwise display "Invalid time". If the user doesn't 
 * provide any values, consider it as invalid time. */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a time value in the 24-hour time format:");
            var input = Console.ReadLine();
            if(string.IsNullOrWhiteSpace(input))
                Console.WriteLine("Invalid time");
            else
            {
                var hour = Convert.ToInt32(input.Split(':')[0]);
                var minute = Convert.ToInt32(input.Split(':')[1]);
                if ((hour >= 0 && hour <= 23) && (minute >= 0 && minute <= 59))
                    Console.WriteLine("Ok");
                else
                    Console.WriteLine("Invalid time");
            }
        }
    }
}
