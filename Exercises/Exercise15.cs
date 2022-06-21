/* Write a program and ask the user to enter a few numbers separated by a hyphen. Work out if the numbers are consecutive. 
 * For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display the message "Consecutive". Otherwise display 
 * "Not Consecutive". */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a few numbers separated by a hyphen:");
            var input = Console.ReadLine();
            var numbers = input.Split('-').Select(int.Parse).ToList();
            bool isConsecutive = false;
            for(var i=1; i<numbers.Count; i++)
            {
                if(numbers[i] - numbers[i-1] == 1 || numbers[i] - numbers[i - 1] == -1)
                    isConsecutive = true;
                else
                    isConsecutive = false;
            }
            if (isConsecutive)
                Console.WriteLine("Consecutive");
            else
                Console.WriteLine("Not Consecutive");
        }
    }
}
