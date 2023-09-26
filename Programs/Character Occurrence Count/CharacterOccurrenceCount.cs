/*
* Output:
  Enter a string:Hello and Welcome to Dotnet Tutorials
  H : 1
  e : 4
  l : 4
  o : 5
  a : 2
  n : 2
  d : 1
  W : 1
  c : 1
  m : 1
  t : 4
  D : 1
  T : 1
  u : 1
  r : 1
  i : 1
  s : 1
*/

using System;

namespace CharacterOccurrenceCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string:");
            string message = Console.ReadLine();
            message = message.Replace(" ", string.Empty);
            while (message.Length > 0)
            {
                Console.Write(message[0] + " : ");
                int count = 0;
                for (int j = 0; j < message.Length; j++)
                {
                    if (message[0] == message[j])
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
                message = message.Replace(message[0].ToString(), string.Empty);
            }
            Console.ReadLine();
        }
    }
}
