/*
* Output:
  Enter number : 245639
  Number of digits is : 6  
*/

using System;

namespace CountNumberOfDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int number = 0, count = 0;
                Console.Write("Enter number : ");
                number = Convert.ToInt32(Console.ReadLine());
                while (number > 0)
                {
                    number = number / 10;
                    count++;
                }
                Console.WriteLine("Number of digits is : " + count);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
