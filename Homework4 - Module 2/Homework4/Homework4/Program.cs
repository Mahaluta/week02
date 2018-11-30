using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{

    class Program
    {

        public static void CommonElements(int[] arr1, int[] arr2)
        {
            var intersection = arr1.Intersect(arr2);
            foreach (int element in intersection)
            {
                Console.Write(element + " ");
            }
        }

        public static bool UniqueCharacters(string word)
        {

            for (int i = 0; i < word.Length; i++)
                for (int j = i + 1; j < word.Length; j++)
                    if ((word[i] == word[j]))
                        return false;
            return true;
        }

        public static bool IsPrime(int x)
        {
            if (x == 1 || x == 2)
                return true;

            for (int i = 2; i <= x / 2; i++)
                if (x % i == 0)
                    return false;
            return true;
        }

        public static string ReverseString(string text)
        {
            char[] arr = text.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        public static bool isPalindrome(string pali)
        {
            if (pali == ReverseString(pali))
                return true;
            return false;
        }

        static void Main()
        {
            // Common elements between two arrays
            int[] arr1 = { 1, 3, -4, 8, -2, 9, 10, 14 };
            int[] arr2 = { 1, 1, 5, 3, 8, 3, -4, 5, 13 };
            Console.Write("Common elements arr1 and arr2: ");
            CommonElements(arr1, arr2);
            Console.WriteLine();

            // Determine if a string has unique characters
            Console.WriteLine("Read a string to see if it has unique characters: ");
            string word = Console.ReadLine();

            if (UniqueCharacters(word.ToLower()) == true)
                Console.WriteLine("The word '" + word + "' has unique characters.");
            else
                Console.WriteLine("The word '" + word + "' doesn't have unique characters.");

            Console.WriteLine();

            // Delete duplicates from a LinkedList
            
            List<int> duplicates = new List<int>() { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 5, 5, 8, 10, 10, 7 };
            Console.Write("duplicates list: ");
            foreach (int element in duplicates)
                Console.Write(element + " ");

            Console.WriteLine();

            List<int> distinct = duplicates.Distinct().ToList();
            Console.Write("distinct list: ");
            foreach (int element in distinct)
                Console.Write(element + " ");
            // With LinkedList --> https://pastebin.com/qMXWuSMF (asta foloseste POO)
            Console.WriteLine();
            Console.WriteLine();
            
            
            // Check if a numbers is prime

            Console.WriteLine("Read a number to check if it's prime: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (IsPrime(num) == true)
                Console.WriteLine("The number " + num + " is prime.");
            else
                Console.WriteLine("The number " + num + " is not prime.");

            Console.WriteLine();

            // Check if a word is a palindrome
            Console.WriteLine("Read a string to see if it's a palindrome: ");
            string pali = Console.ReadLine();
            if(isPalindrome(pali)==true)
                Console.WriteLine("The word '" + pali + "' is a palindrome.");
            else
                Console.WriteLine("The word '" + pali + "' is not a palindrome.");
            


            Console.ReadKey();
        }
    }
}
