/*
* Output:
  Enter a string : Google
  Gogle   
*/

using System;
using System.Linq;

namespace DuplicateCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string : ");
            string inputString = Console.ReadLine();
            string resultString = string.Empty;
            for (int i = 0; i < inputString.Length; i++)
            {
                if (!resultString.Contains(inputString[i]))
                {
                    resultString = resultString + inputString[i];
                }
            }
            Console.WriteLine(resultString);
            Console.ReadKey();
        }
    }
}
