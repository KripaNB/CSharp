/* Design a class called Stopwatch. The job of this class is to simulate a stopwatch. It should provide 2 methods: Start and Stop.
 * We call the start method first, and the stop method next. Then we ask the stopwatch about the duration between start and stop. 
 * Duration should be a value in TimeSpan. Display the duration on the console. We should also be able to use a stopwatch multiple 
 * times. So we may start and stop it and then start and stop it again. Make sure the suration value each time is calculated 
 * properly. We should not be able to start a stopwatch twice in a row (because that might overwrite the initial start time). So the 
 * class should throw an InvalidOperationException if its started twice. */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new StopWatch();
            do
            {
                Console.WriteLine("Enter START or STOP for the stopwatch to start or stop respectively and EXIT to exit the program:");
                var input = Console.ReadLine();
                if (input == "START")
                {
                    stopwatch.Start();
                }
                if (input == "STOP")
                {
                    stopwatch.Stop();
                    Console.WriteLine(stopwatch.Duration.ToString());
                }
                if (input == "EXIT")
                    break;
            }
            while (true);              
        }
    }
}
