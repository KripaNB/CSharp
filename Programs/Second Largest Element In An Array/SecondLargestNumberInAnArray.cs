/*
 * Output:
Input the size of array:
5
Input 5 elements in the array:
element - 0 : 35
element - 1 : 4
element - 2 : 56
element - 3 : 89
element - 4 : 104
The Second largest element in the array is:  89 
*/

using System;

namespace SecondLargestNumberInAnArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, i, j = 0, largest, secondLargest;
            int[] arr1 = new int[50];
            Console.WriteLine("Input the size of array: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input {0} elements in the array: ", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            largest = 0;
            for (i = 0; i < n; i++)
            {
                if (largest < arr1[i])
                {
                    largest = arr1[i];
                    j = i;
                }
            }
            secondLargest = 0;
            for (i = 0; i < n; i++)
            {
                if (i == j)
                {
                    continue;

                }
                else
                {
                    if (secondLargest < arr1[i])
                    {
                        secondLargest = arr1[i];
                    }
                }
            }

            Console.WriteLine("The Second largest element in the array is:  {0} ", secondLargest);
        }
    }
}
