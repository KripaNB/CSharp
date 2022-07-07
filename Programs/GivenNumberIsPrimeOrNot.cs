using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GivenNumberIsPrimeOrNot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isPrime = true;
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            for ( int i = 2; i < number/2; i++ )
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }                    

            }
            if (isPrime)
                Console.WriteLine("The number is Prime");
            else
                Console.WriteLine("The number is not Prime");
        }
    }
}
