using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Exercitii
    {
        public static int ArraySum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
                sum += arr[i];
            return sum;
        }

        public static int ArrayAverage(int[] arr)
        {
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
                counter += arr[i];
            return counter / arr.Length;
        }

        public static int FindIndex(int[] arr, int element)
        {
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] == element)
                    return i;
            return -1;
        }

        public static int MAXArray(int[] arr)
        {
            int MAX = arr[0];
            for (int i = 1; i < arr.Length; i++)
                if (arr[i] > MAX)
                    MAX = arr[i];
            return MAX;

        }

        public static int MINArray(int[] arr)
        {
            int MIN = arr[0];
            for (int i = 1; i < arr.Length; i++)
                if (arr[i] < MIN)
                    MIN = arr[i];
            return MIN;

        }

        public static void CommonElements(int[] arr1, int[] arr2)
        {
            for (int i = 0; i < arr1.Length; i++)
                for (int j = 0; j < arr2.Length; j++)
                    if (arr1[i] == arr2[j])
                        Console.Write(arr1[i] + " ");
        }

        public static void Main()
        {
            int[] arr = { 1, 3, 2, 5, 6, 8, 10 };
            Console.Write("The array that we're working with is: ");
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();


            Console.WriteLine();
            // Array Sum
            Console.WriteLine("The sum of the array is: " + ArraySum(arr));


            Console.WriteLine();
            // Array Average
            Console.WriteLine("The average of the array is: " + ArrayAverage(arr));


            Console.WriteLine();
            // Find the index of an element
            Console.WriteLine("Type a number to find his index in the array: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int index = FindIndex(arr, num);
            if (index == -1)
                Console.WriteLine("The number is not in the specified array!");
            else
                Console.WriteLine("The index of the number is: " + index);



            Console.WriteLine();
            // Remove item from an array (List<T>)

            List<int> numbers = new List<int>() { 1, 3, 2, 5, 6, 8, 10 };
            Console.WriteLine("Read number to remove from list");
            int x = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numbers.Count; i++)
            {

                if (x == numbers[i])
                {
                    numbers.RemoveAt(i);

                }
                if (i != numbers.Count)
                    Console.Write(numbers[i] + " ");

            }
            Console.WriteLine();

            Console.WriteLine();
            // Add item to an array (List<T>) at a specified position
            Console.WriteLine("Read an index for a position and the element that you want to add in the list");
            int indexToAdd = Convert.ToInt32(Console.ReadLine());
            int numberToAdd = Convert.ToInt32(Console.ReadLine());
            numbers.Insert(indexToAdd, numberToAdd);
            for (int i = 0; i < numbers.Count; i++)
                Console.Write(numbers[i] + " ");
            Console.WriteLine();

            Console.WriteLine();
            // MIN and MAX from an array
            Console.WriteLine("The MIN of the array is: " + MINArray(arr));
            Console.WriteLine("The MAX of the array is : " + MAXArray(arr));


            Console.WriteLine();
            // Common elements between two arrays
            Console.WriteLine("Common elements arr1 and arr2: ");
            int[] arr1 = { 1, 3, 4, 8, 2, 9 };
            int[] arr2 = { 1, 5, 3, 8, 4, 5, 13 };
            CommonElements(arr1, arr2);
            Console.WriteLine();

            Console.WriteLine();
            // Transfer elements between two arrays
            Console.WriteLine("Copy the elements from arr3 in arr4.");
            int[] arr3 = { 1, 3, 4, 8, 2, 9 };
            int[] arr4 = new int[arr3.Length];
            for (int i = 0; i < arr3.Length; i++)
            {
                arr4[i] = arr3[i];
                Console.Write(arr4[i] + " ");
            }



        }
    }
}