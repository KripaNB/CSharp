/* Write a program that reads a text file and displays the number of words. */


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Kripa Bangera\source\repos\Exercise20\Exercise20\words.txt";
            var text = File.ReadAllText(path);
            var textArray = text.Split(' ').ToArray();
            Console.WriteLine("Number of words: " + textArray.Length);
        }
    }
}
