using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintPrimeNumbersBetweenARange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the start number:");
            int startNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the end number:");
            int endNumber = Convert.ToInt32(Console.ReadLine());
            for (int i = startNumber; i <= endNumber; i++)
            {
                int counter = 0;
                for (int j = 2; j <= i/2; j++)
                {
                    if (i % j == 0)
                    {
                        counter++;
                        break;
                    }
                }
                if (counter == 0 && i != 1)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
