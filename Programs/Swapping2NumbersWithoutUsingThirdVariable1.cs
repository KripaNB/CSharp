using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swapping2NumbersWithoutUsingThirdVariable1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number:");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int temp = 0;
            Console.WriteLine("The numbers before swapping : number1 = " + number1 + "; number2 = " + number2);
            number1 = number1 * number2;
            number2 = number1 / number2;
            number1 = number1 / number2;
            Console.WriteLine("The numbers after swapping are : number1 = " + number1 + "; number2 = " + number2);
        }
    }
}
