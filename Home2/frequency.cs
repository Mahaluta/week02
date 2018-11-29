using System;
using System.Collections.Generic;

namespace ConsoleApplication
{

    public class Frequency
    {

        public static void Main()
        {
            int[] arr = { 1, 1, 3, 5, 4, 3, 4, 5, 6, 7, 5, 4, 6, 7, 8, 9, 9 };
            int[] frequency = new int[10];
            Console.WriteLine("The current array is: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
                frequency[arr[i]]++;
            }
            Console.WriteLine();
            Console.WriteLine("The frequency of the array is: ");
            for (int i = 0; i < frequency.Length; i++)

                if (frequency[i] != 0)
                    if (frequency[i] != 1)
                        Console.WriteLine(i + " - " + frequency[i] + " times");
                    else
                        Console.WriteLine(i + " - one time");
        }
    }
}