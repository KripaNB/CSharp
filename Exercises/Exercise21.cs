/* Write a program that reads a text file and displays the longest word in the file. */


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Kripa Bangera\source\repos\Exercise21\Exercise21\words.txt";
            var text = File.ReadAllText(path);
            var textArray = text.Split(' ');
            var longestWord = "";
            foreach (var word in textArray)
            {
                if(longestWord.Length < word.Length)
                    longestWord = word;
            }
            Console.WriteLine("Longest word in the file: " + longestWord);
        }
    }
}
