/*
 * Output:
   Enter a string:
   Kripa
   Enter another string:
   Bangera
   The numbers before swapping : name1 = Kripa; name2 = Bangera
   The numbers after swapping are : name1 = Bangera; name2 = Kripa 
*/
using System;

namespace Swapping2StringsWithoutUsingThirdVariable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string name1 = Console.ReadLine();
            Console.WriteLine("Enter another string:");
            string name2 = Console.ReadLine();
            Console.WriteLine("The strings before swapping : name1 = " + name1 + "; name2 = " + name2);
            name1 = name1 + name2;
            name2 = name1.Substring(0, name1.Length - name2.Length);
            name1 = name1.Substring(name2.Length);
            Console.WriteLine("The strings after swapping are : name1 = " + name1 + "; name2 = " + name2);
        }
    }
}
