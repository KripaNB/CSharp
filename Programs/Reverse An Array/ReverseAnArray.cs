/*
* Output:
  Original Array Elements : 1 2 3 4 5
  Reversed Array Elements : 5 4 3 2 1  
*/

using System;

namespace ReverseAnArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            Console.Write("Original Array Elements : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            ReverseElements(arr, 0, (arr.Length - 1));
            Console.Write("\nReversed Array Elements : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.ReadKey();
        }

        public static void ReverseElements(int[] arr, int startIndex, int endIndex)
        {
            while (startIndex < endIndex)
            {
                int temp = arr[startIndex];
                arr[startIndex] = arr[endIndex];
                arr[endIndex] = temp;
                startIndex++;
                endIndex--;
            }
        }
    }
}
