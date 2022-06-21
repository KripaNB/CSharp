/* Write a program that asks the user to enter the speed limit. Once set, the program asks for the speed of a car.
 * If the user enters a value less than the speed limit, program should display "OK" on the console. If the value is above 
 * the speed limit, the program should calculate the number of demerit points. For every 5km/hr above the speed limit,
 * 1 demerit points should be incurred and displayed on the console. If the number of demerit points is above 12,
 * the program should display "Lisence Suspended". */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the speed limit in km/hr:");
            int speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the speed of the car in km/hr:");
            int carSpeed = Convert.ToInt32(Console.ReadLine());
            if (carSpeed <= speedLimit)
                Console.WriteLine("Ok!!");
            if (carSpeed > speedLimit)
            {
                int speedDifference = carSpeed - speedLimit;
                if (speedDifference >= 1 && speedDifference <= 5)
                    Console.WriteLine("Demerit Points : 1");
                else if (speedDifference > 5 && speedDifference <= 10)
                    Console.WriteLine("Demerit Points : 2");
                else if (speedDifference > 10 && speedDifference <= 12)
                    Console.WriteLine("Demerit Points : 3");
                else if (speedDifference > 12)
                    Console.WriteLine("License Suspended");
            }
            Console.ReadLine();
        }
    }
}
