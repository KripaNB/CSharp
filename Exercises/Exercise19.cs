/* Write a program and ask the user to enter an English word. Count the number of vowels (a,e,i,o,u) in the word.
 * So, if the user enters "inadequate" the program should display 6 on the console. */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an english word:");
            var input = Console.ReadLine();
            int vowelCount = 0;
            for (int j = 0; j < input.Length; j++)
            {
                if(input[j] == 'a' || input[j] == 'e' || input[j] == 'i' || input[j] == 'o' || input[j] == 'u')
                    vowelCount++;
            }
            Console.WriteLine("Count of vowels in the word:" + vowelCount);
        }
    }
}
