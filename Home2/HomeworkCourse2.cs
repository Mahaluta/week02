using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class HomeworkCourse2
    {
        public static void FizzBuzz()
        {
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine("FizzBuzz");
                else if (i % 3 == 0)
                    Console.WriteLine("Fizz");
                else if (i % 5 == 0)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i);
            }
        }
        public static void Main()
        {
            //FizzBuzz
            FizzBuzz();
            Console.WriteLine();


            //frequency
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

                if(frequency[i] != 0)
                    if(frequency[i]!=1)
                        Console.WriteLine(i + " - " + frequency[i] + " times");
                    else
                        Console.WriteLine(i + " - one time");

            //Odd&Even numbers in different arrays
                Console.WriteLine("How many numbers do you want to read?");
                    int n = Convert.ToInt32(Console.ReadLine());
                    List<int> oddNumbers = new List<int>();
                    List<int> evenNumbers = new List<int>();
                int[] array = new int[n];
                    Console.WriteLine("Okay. Read the numbers");
                for(int i=0;i<n;i++)
                  {  array[i] = Convert.ToInt32(Console.ReadLine());
                    if(array[i]%2==0)
                        evenNumbers.Add(array[i]);
                    else
                        oddNumbers.Add(array[i]);
                  }

                for(int i=0;i<evenNumbers.Count;i++)
                    Console.Write(evenNumbers[i]+ " ");
                Console.WriteLine();
                for(int i=0;i<oddNumbers.Count;i++)
                    Console.Write(oddNumbers[i] + " ");


        }
    }
}