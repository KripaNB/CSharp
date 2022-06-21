/* Write a program and ask the user to enter the width and height of an image. Then tell if the image is landscape or portrait. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width, height;
            Console.WriteLine("Enter the width of the image:");
            width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the height of the image:");
            height = Convert.ToInt32(Console.ReadLine());
            if (width > height)
                Console.WriteLine("The image is landscape.");
            else if (height > width)
                Console.WriteLine("The image is portrait.");
            else if (width == height)
                Console.WriteLine("The image is square.");
        }
    }
}
