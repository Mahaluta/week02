using System;
namespace ConsoleApplication
{
    public class Home2
    {
        public static void PrintEven(int a, int b)
        {
            for (int i = a; i <= b; i++)
                if (i % 2 == 0)
                    Console.Write(i + " ");
            Console.WriteLine();
            Console.WriteLine();
        }

        public static void PrintDiv3(int a, int b)
        {
            for (int i = a; i <= b; i++)
                if (i % 3 == 0)
                    Console.Write(i + " ");
            Console.WriteLine();
        }

        public static int CountNumDiv7Mul5(int a, int b)
        {
            Console.WriteLine();
            int counter = 0;
            for (int i = a; i <= b; i+=5)
                if ((i % 7 == 0) && (i % 5 == 0))
                    counter++;
            return counter;

        }

        public static string ReverseString(string text)
        {
            char[] arr = text.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        public static int Fibonacci(int n)
        {
            int a = 0, b = 1, aux;
            for (int i = 0; i < n; i++)
            {
                aux = a;
                a = b;
                b = aux + b;
            }
            return a;
        }

        public static int ArraySum(int[] arr)
        {
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
                counter += arr[i];
            return counter;
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

        //NU MERGE functia
        public static void DeleteElement(int[] arr, int element)
        {
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] == element)
                    for (int j = i; j < arr.Length - 1; j++)
                        arr[j] = arr[j + 1];

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
        public static void Main()
        {
            //Print even numbers function
            Console.WriteLine("Even numbers between 15,97: ");
            PrintEven(15, 97);

            //Print numbers divisible by 3
            Console.WriteLine("Divisible numbers by 3 between 20,65: ");
            PrintDiv3(20, 65);

            //Print numbers div by 7, multiple of 5
            Console.WriteLine("Numbers divisible by 7 and multiple of 5 between 1400,2300: " + CountNumDiv7Mul5(1400, 2300));
            Console.WriteLine();

            //Generating a random number
            Random rnd = new Random();
            int number = rnd.Next(0, 11);
            Console.WriteLine("Random number generated between 1,10: " + number);
            Console.WriteLine();

            //Writing reversed text
            string text = Console.ReadLine();
            Console.WriteLine("Reversed string: " + ReverseString(text));
            Console.WriteLine();

            //Printing numbers from 1 to 10 without 4 and 7
            Console.WriteLine("Numbers between 1,10 without 4,7: ");
            for (int i = 1; i <= 10; i++)
            {
                if ((i == 4) || (i == 7))
                    continue;
                Console.Write(i + " ");
            }
            Console.WriteLine();

            //Fibonacci function
            Console.WriteLine();
            Console.WriteLine("Fibonacci: ");
            for (int i = 0; i < 10; i++)
                Console.Write(Fibonacci(i) + " ");
            Console.WriteLine();

            //Array sum
            int[] arr = { 10, 20, 30, 40, 50 };
            Console.WriteLine();
            Console.WriteLine("The sum of the array is: " + ArraySum(arr));

            //Average Value of an array elements
            Console.WriteLine();
            Console.WriteLine("The average of the array is: " + ArrayAverage(arr));

            //Find index of an element;
            Console.WriteLine();
            Console.WriteLine("The index of the element 30 is: " + FindIndex(arr, 30));
            if (FindIndex(arr, 60) == -1)
                Console.WriteLine("The element 60 could not be found in the array.");
            Console.WriteLine();

            //Delete element form an array;

            //MAX Array
            Console.WriteLine("The max of the array is: " + MAXArray(arr));
            Console.WriteLine();
            //MIN Array
            Console.WriteLine("The min of the array is: " + MINArray(arr));
            Console.WriteLine();

            //Common elements between arrays
            Console.WriteLine("Common elements between 2 arrays: ");
            int[] arr1 = { 1, 3, 4, 8, 2, 9 };
            int[] arr2 = { 1, 5, 3, 8, 4, 5, 13 };
            for (int i = 0; i < arr1.Length; i++)
                for (int j = 0; j < arr2.Length; j++)
                    if (arr1[i] == arr2[j])
                        Console.Write(arr1[i] + " ");

            //Copy element from an array to another;
            
        }
    }
}