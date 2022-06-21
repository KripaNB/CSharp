/* Write a program and ask teh user to enter 5 numbers. If a number has been previously entered, display an error 
 * message and ask the user to retry. Once the user successfully enters 5 unique numbers, sort them and display the 
 * result on the console. */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 5 numbers:");
            var numbers = new List<int>();
            while (true)
            {
                var number = Convert.ToInt32(Console.ReadLine());
                if (numbers.Contains(number))
                    Console.WriteLine("The number already exists. Re-try");
                else
                    numbers.Add(number);
                if (numbers.Count == 5)
                {
                    numbers.Sort();
                    break;
                }
                else
                    continue;
            }
            Console.WriteLine("Sorted 5 Unique Numbers are:");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);                
            }
            Console.ReadLine();
        }
    }
}
