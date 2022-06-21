/* Write a program which takes 2 numbers from the console and displays the maximum of the two. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string value;
            int a, b;
            var values = new string[2];
            Console.WriteLine("Enter 2 numbers:");
            value = Console.ReadLine();
            values = value.Split(' ');
            a = int.Parse(values[0]);
            b = int.Parse(values[1]);

            Console.WriteLine("Maximum of the 2 numbers are:");
            if (a > b)
                Console.WriteLine(a);
            else
                Console.WriteLine(b);
        }
    }
}
