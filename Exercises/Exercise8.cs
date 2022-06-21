/* Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number.
 * If the user guesses the number, display "You won", otherwise display "You lost". */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            int randomNumber = random.Next(1, 10);
            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine("Guess the random number:");
                int guessNumber = Convert.ToInt32(Console.ReadLine());
                if (guessNumber == randomNumber)
                {
                    Console.WriteLine("You won.");
                    break;
                }
                if (guessNumber != randomNumber)
                {
                    if (i == 4)
                    {
                        Console.WriteLine("You lost.");
                        break;
                    }
                    else
                        Console.WriteLine("Wrong guess.");
                }
            }
            Console.ReadLine();
        }
    }
}
