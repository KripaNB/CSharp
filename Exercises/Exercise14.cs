/* Write a program and ask the user to supply a list of comma separated numbers (Eg: 5,1,9,2,10). If the list 
 * is empty or includes less than 5 numbers, display "Invalid List" amd ask the user to retry. Otherwise, display 
 * the three smallest numbers in the list. */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a list of numbers separated by commas:");
            var input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
                Console.WriteLine("The list cannot be empty or null. Please retry.");
            else
            {
                string[] stringList = input.Split(',');
                var numberList = new List<int>();
                numberList = stringList.Select(int.Parse).ToList();
                numberList.Sort();
                if (numberList.Count < 5)
                    Console.WriteLine("Invalid list, has less than 5 numbers. Please retry.");
                else
                {
                    var smallestNumberList = new List<int>();
                    for (int i = 0; i < 3; i++)
                        smallestNumberList.Add(numberList[i]);
                    Console.WriteLine("The smallest numbers in the list are:");
                    foreach (var num in smallestNumberList)
                        Console.WriteLine(num);
                }
                Console.ReadLine();
            }
        }
    }
}
