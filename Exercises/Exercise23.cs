/* Design a class called Post. This class models a StackOverflow post. It should have properties for title, description and 
 * the date/time it was created. We should be able to up-vote or down-vote a post. We should also be able to see the current 
 * vote value. In the main method, create a post, up-vote and down-vite it a few times and then display the current vote value. 
 * In this exercise, you will learn that a StackOverflow post should provide methods for up-voting or down-voting. You should not 
 * give the ability to set the Vote property from outside, because otherwise you may accidently change the votes of a class to 0 
 * or to a random number. And this is how we create bugs in our program. The class should always protect its state and hide its 
 * implementation details. */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a title for your post:");
            var title = Console.ReadLine();
            Console.WriteLine("Enter a description for your post:");
            var description = Console.ReadLine();
            var post = new Post(title, description);
            do
            {
                Console.WriteLine("Up-vote or Down-vote the post by typing in UP or DOWN. Type EXIT to exit out of the program:");
                var input = Console.ReadLine();
                if (input == "UP")
                {
                    post.UpVote();
                    Console.WriteLine("Total number of votes: {0}", post.Votes);
                }                    
                if (input == "DOWN")
                {
                    post.DownVote();
                    Console.WriteLine("Total number of votes: {0}", post.Votes);
                }                
                if (input == "EXIT")
                    break;
            }
            while (true);
        }
    }
}
