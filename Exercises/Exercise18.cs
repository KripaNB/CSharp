/* Write a program and ask the userto enter a few words separated by a space. Use the words to create a variable name with PascalCase.
 * For example, if the user types "Number of students", displays "NumberOfStudents". MAke sure that the program is not dependent on the 
 * input. So if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents". */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in any word/phrase to be converted to PascalCase:");
            var input = Console.ReadLine().ToLower();
            if(string.IsNullOrWhiteSpace(input))
                Console.WriteLine("Invalid input");
            var words = input.Split(' ').ToArray();
            for(var i=0; i<words.Length; i++)
            {
                words[i] = words[i].Substring(0, 1).ToUpper() + words[i].Substring(1);
            }
            var result = String.Concat(words);
            Console.WriteLine("Pascal Case variable:" + result);
        }
    }
}
