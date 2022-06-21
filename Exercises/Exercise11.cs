/* Write a program and ask the user to enter their names. Use an array to reverse the name and then store the 
 * result in a new string. Display the reversed name on the console. */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name:");
            var name = Console.ReadLine();
            var nameList = name.ToArray();
            var reversedNameList = nameList.Reverse();
            var reversedName = string.Join("", reversedNameList);
            Console.WriteLine("The name of {0} gets reversed to {1}", name, reversedName);
        }
    }
}
