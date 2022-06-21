/* Write a program to ask teh user to continuously enter a number or type "Quit" to exit. The list of numbers
 * may include duplicates. Display the unique numbers that the user has entered. */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter whatever number you like or 'quit' to exit out and view the results");
            var numbers = new List<int>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input.ToLower() == "quit")
                {
                    numbers.Sort();
                    Console.WriteLine("The unique numbers entered in sorted order are:");
                    var uniqueNumbers = numbers.Distinct().ToList();
                    foreach (var num in uniqueNumbers)
                    {
                        Console.WriteLine(num);
                    }
                    break;
                }
                else
                    numbers.Add(Convert.ToInt32(input));
            }
            Console.ReadLine();
        }
    }
}
