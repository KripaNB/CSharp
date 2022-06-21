/* Write a program and ask the user to enter a few numbers separated by a hyphen. If the user simply enters Enter, 
 * without supplying an input, exit immediately. Otherwise, check to see if there are duplicates. If so, display
 * "Duplicate" on the console. */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a few numbers separated by hyphen:");
            var input = Console.ReadLine();
            var numbers = input.Split('-').Select(int.Parse).ToList();
            if (string.IsNullOrWhiteSpace(input))
                Environment.Exit(0);
            if(numbers.Count != numbers.Distinct().Count())
                Console.WriteLine("Duplicate");
            else
                Console.WriteLine("Not Duplicate");
        }
    }
}
