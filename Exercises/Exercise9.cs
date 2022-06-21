/* Write a program and ask the user to enter a series of numbers separated by comma. Find the maximum of the numbers
 * and display it on the console. */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a series of numbers separated by comma:");
            var input = Console.ReadLine();
            string[] stringList = input.Split(',');
            //int[] numberList = Array.ConvertAll(stringList, int.Parse);
            int[] numberList = stringList.Select(int.Parse).ToArray();
            Console.WriteLine(numberList.Max());
            Console.ReadLine();
        }
    }
}
