/* When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.
 * (a) If no one likes your post, it doesn't display anything.
 * (b) If only one person likes your post, it displays : [Friend's Name] likes your post.
 * (c) If 2 people like your post, it displays : [Friend 1] and [Friend 2] like your post.
 * (d) if more than 2 people like your post, it displays : [Friend 1], [Friend 2] and [Number of other people] others like your post. 
 * Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name).
 * Depending on the number of names provided, display a message based on the above pattern. */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>();
            while (true)
            {
                Console.Write("Enter a name:");
                var name = Console.ReadLine();
                if (string.IsNullOrEmpty(name))
                    break;
                names.Add(name);
                if (names.Count == 1)
                    Console.WriteLine("{0} likes your post.", names[0]);
                else if (names.Count == 2)
                    Console.WriteLine("{0} and {1} like your post.", names[0], names[1]);
                else if (names.Count > 2)
                    Console.WriteLine("{0}, {1} and {2} others like your post.", names[0], names[1], names.Count-2);
            }
            Console.ReadLine();
        }
    }
}
