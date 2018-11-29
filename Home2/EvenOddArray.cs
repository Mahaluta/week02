using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class EvenOddArray
    {

        public static void Main()
        {
            Console.WriteLine("How many numbers do you want to read?");
            int n = Convert.ToInt32(Console.ReadLine());

            List<int> oddNumbers = new List<int>();
            List<int> evenNumbers = new List<int>();
            int[] array = new int[n];

            Console.WriteLine("Okay. Read the numbers");
            for (int i = 0; i < n; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
                if (array[i] % 2 == 0)
                    evenNumbers.Add(array[i]);
                else
                    oddNumbers.Add(array[i]);
            }

            Console.Write("The odd numbers are: ");
            foreach(int element in oddNumbers) {Console.Write(element + " ");}
            Console.WriteLine();
            Console.Write("The even numbers are: ");
            foreach(int element in evenNumbers) {Console.Write(element + " ");}
        }
    }
}